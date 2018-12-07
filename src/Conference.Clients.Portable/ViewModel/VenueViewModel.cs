using FormsToolkit;
using Plugin.ExternalMaps;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Conference.Clients.Portable
{
    public class VenueViewModel : ViewModelBase
    {
        //TODO: Does Xamarin.Essentials support this?
        public bool CanMakePhoneCall => true;
        public string EventTitle => "AZURE DAY BELARUS";
        public string LocationTitle => "HTP Belarus";
        public string Address1 => "vulісa Akadеmіka Kuprеvіča 1/1";
        public string Address2 => "Minsk 220141";
        public double Latitude => 53.927133;
        public double Longitude => 27.681972;

        ICommand  navigateCommand;
        public ICommand NavigateCommand =>
            navigateCommand ?? (navigateCommand = new Command(async () => await ExecuteNavigateCommandAsync())); 

        async Task ExecuteNavigateCommandAsync()
        {
            Logger.Track(ConferenceLoggerKeys.NavigateToConference);
            if(!await CrossExternalMaps.Current.NavigateTo(LocationTitle, Latitude, Longitude))
            {
                MessagingService.Current.SendMessage(MessageKeys.Message, new MessagingServiceAlert
                    {
                        Title = "Unable to Navigate",
                        Message = "Please ensure that you have a map application installed.",
                        Cancel = "OK"
                    });
            }
        }

        ICommand  callCommand;
        public ICommand CallCommand =>
            callCommand ?? (callCommand = new Command(ExecuteCallCommand)); 

        void ExecuteCallCommand()
        {
            Logger.Track(ConferenceLoggerKeys.CallHotel);
            try
            {
                PhoneDialer.Open("+375172686911");
            }
            catch (FeatureNotSupportedException)
            {
                Application.Current?.MainPage?.DisplayAlert("Sorry!", "Your device doesn't appear to support phone calls!", "OK");
            }
        }
    }
}


