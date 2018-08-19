using System;
using Xamarin.Forms;
using Conference.DataObjects;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Windows.Input;
using FormsToolkit;
using System.Collections.Generic;

namespace Conference.Clients.Portable
{
    public class FeedbackViewModel : ViewModelBase
    {
        Session session;
        public Session Session
        {
            get { return session; }
            set { SetProperty(ref session, value); }
        }


        public FeedbackViewModel(INavigation navigation, Session session) : base(navigation)
        {
            Session = session;
        }

        ICommand submitRatingCommand;
        public ICommand SubmitRatingCommand =>
            submitRatingCommand ?? (submitRatingCommand = new Command<RatingSession>(async (rating) =>
                                                                           await ExecuteSubmitRatingCommandAsync(rating)));

        public async Task ExecuteSubmitRatingCommandAsync(RatingSession rating)
        {
            if (IsBusy)
                return;

            IsBusy = true;
            try
            {
                if (rating == null)
                {

                    MessagingService.Current.SendMessage<MessagingServiceAlert>(MessageKeys.Message, new MessagingServiceAlert
                    {
                        Title = "No Rating Selected",
                        Message = "Please select a rating to leave feedback for this session.",
                        Cancel = "OK"
                    });
                    return;
                }

                EvaluationsViewModel.ForceRefresh = true;
                Logger.Track(ConferenceLoggerKeys.LeaveFeedback, "Title", rating.ToString());

                MessagingService.Current.SendMessage<MessagingServiceAlert>(MessageKeys.Message, new MessagingServiceAlert
                {
                    Title = "Feedback Received",
                    Message = "Thanks for the feedback, have a great Conference.",
                    Cancel = "OK",
                    OnCompleted = async () =>
                    {
                        await Navigation.PopModalAsync();
                        if (Device.RuntimePlatform == Device.Android)
                            MessagingService.Current.SendMessage("eval_finished");
                    }
                });

                Session.FeedbackLeft = true;
                await StoreManager.FeedbackStore.InsertAsync(new Feedback
                {
                    SessionId = session.Id,
                    SessionRating = rating.SessionRating,
                    Prepeared = rating.Prepeared,
                    Learnnew = rating.Learnnew,
                    StayedinFocus = rating.StayedInFocus,
                    Expertise = rating.Expertise
                });
            }
            catch (Exception ex)
            {
                Logger.Report(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }


    }
}

