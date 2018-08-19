using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Conference.DataObjects;
using Conference.Clients.Portable;

namespace Conference.Clients.UI
{
    public partial class FeedbackPage : ContentPage
    {
        FeedbackViewModel vm;
        public FeedbackPage(Session session)
        {
            InitializeComponent();

            BindingContext = vm = new FeedbackViewModel(Navigation, session);
            if (Device.RuntimePlatform != Device.iOS)
                ToolbarDone.Icon = "toolbar_close.png";

            ToolbarDone.Command = new Command(async () => 
                {
                    if(vm.IsBusy)
                        return;
                    
                    await Navigation.PopModalAsync();
                });
        }

        private async void SubmitRating_OnClicked(object sender, EventArgs e)
        {
            var rating = new RatingSession()
            {
               SessionRating = Session.Rating,
               Expertise = Expertise.Rating,
               Learnnew = LearnNew.Rating,
               Prepeared = Prepared.Rating,
               StayedInFocus = StayedInFocus.Rating
            };
            
            await vm.ExecuteSubmitRatingCommandAsync(rating);
        }
    }
}

