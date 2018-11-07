using Conference.DataObjects;
using System.Collections.Generic;

namespace Conference.Backend.Services
{
    public class SponsorService : BaseService<Sponsor>
    {
        private static string BaseUrl = "http://azuredaymobile.azurewebsites.net";

        protected override List<Sponsor> PopulateStorage()
        {
            return new List<Sponsor>
            {
                new Sponsor
                {
                    Name = AzureDay.WebApp.Localization.App.Service.Partners.Microsoft.Title,
                    SponsorLevel = new SponsorLevel {Name = "Gold", Rank = 0},
                    Description = AzureDay.WebApp.Localization.App.Service.Partners.Microsoft.Description,
                    ImageUrl = string.Format("{0}/content/images/logos/microsoft.jpg", BaseUrl),
                    WebsiteUrl = "https://www.microsoft.com/uk-ua/"
                },
                new Sponsor
                {
                    Name = AzureDay.WebApp.Localization.App.Service.Partners.Luxoft.Title,
                    SponsorLevel = new SponsorLevel {Name = "Gold", Rank = 0},
                    Description = AzureDay.WebApp.Localization.App.Service.Partners.Luxoft.Description,
                    ImageUrl = string.Format("{0}/content/images/logos/Luxoft_v1.jpg", BaseUrl),
                    WebsiteUrl = "https://www.luxoft.com/"
                },
                new Sponsor
                {
                    Name = AzureDay.WebApp.Localization.App.Service.Partners.Beetroot.Title,
                    SponsorLevel = new SponsorLevel {Name = "Info", Rank = 3},
                    Description = AzureDay.WebApp.Localization.App.Service.Partners.Beetroot.Description,
                    ImageUrl = string.Format("{0}/content/images/logos/Beetroot_v1.png", BaseUrl),
                    WebsiteUrl = "https://beetroot.se/"
                },
                new Sponsor
                {
                    Name = AzureDay.WebApp.Localization.App.Service.Partners.Bodo.Title,
                    SponsorLevel = new SponsorLevel {Name = "Info", Rank = 3},
                    Description = AzureDay.WebApp.Localization.App.Service.Partners.Bodo.Description,
                    ImageUrl = string.Format("{0}/content/images/logos/bodo.png", BaseUrl),
                    WebsiteUrl = "https://www.bodo.ua/"
                },
                new Sponsor
                {
                    Name = AzureDay.WebApp.Localization.App.Service.Partners.BrainBasket.Title,
                    SponsorLevel = new SponsorLevel {Name = "Info", Rank = 3},
                    Description = AzureDay.WebApp.Localization.App.Service.Partners.BrainBasket.Description,
                    ImageUrl = string.Format("{0}/content/images/logos/BrainBasketFoundation_v1.png", BaseUrl),
                    WebsiteUrl = "https://brainbasket.org/"
                },
                new Sponsor
                {
                    Name = AzureDay.WebApp.Localization.App.Service.Partners.BrainTV.Title,
                    SponsorLevel = new SponsorLevel {Name = "Info", Rank = 3},
                    Description = AzureDay.WebApp.Localization.App.Service.Partners.BrainTV.Description,
                    ImageUrl = string.Format("{0}/content/images/logos/brain_tv.jpg", BaseUrl),
                    WebsiteUrl = "https://braintv.net/"
                },
                new Sponsor
                {
                    Name = AzureDay.WebApp.Localization.App.Service.Partners.DevArt.Title,
                    SponsorLevel = new SponsorLevel {Name = "Info", Rank = 3},
                    Description = AzureDay.WebApp.Localization.App.Service.Partners.DevArt.Description,
                    ImageUrl = string.Format("{0}/content/images/logos/devart_v1.png", BaseUrl),
                    WebsiteUrl = "https://www.devart.com/"
                },
                new Sponsor
                {
                    Name = AzureDay.WebApp.Localization.App.Service.Partners.Dou.Title,
                    SponsorLevel = new SponsorLevel {Name = "Info", Rank = 3},
                    Description = AzureDay.WebApp.Localization.App.Service.Partners.Dou.Description,
                    ImageUrl = string.Format("{0}/content/images/logos/dou.png", BaseUrl),
                    WebsiteUrl = "https://dou.ua/"
                },
                new Sponsor
                {
                    Name = AzureDay.WebApp.Localization.App.Service.Partners.ITClusterKonotop.Title,
                    SponsorLevel = new SponsorLevel {Name = "Info", Rank = 3},
                    Description = AzureDay.WebApp.Localization.App.Service.Partners.ITClusterKonotop.Description,
                    ImageUrl = string.Format("{0}/content/images/logos/itclusterkonotop_v1.png", BaseUrl),
                    WebsiteUrl = "http://itcluster.konotop.info/"
                },
                new Sponsor
                {
                    Name = AzureDay.WebApp.Localization.App.Service.Partners.ITRatingUkraine.Title,
                    SponsorLevel = new SponsorLevel {Name = "Info", Rank = 3},
                    Description = AzureDay.WebApp.Localization.App.Service.Partners.ITRatingUkraine.Description,
                    ImageUrl = string.Format("{0}/content/images/logos/itratingsukraine_v1.png", BaseUrl),
                    WebsiteUrl = "https://it-rating.in.ua/"
                },
                new Sponsor
                {
                    Name = AzureDay.WebApp.Localization.App.Service.Partners.KyivITCluster.Title,
                    SponsorLevel = new SponsorLevel {Name = "Info", Rank = 3},
                    Description = AzureDay.WebApp.Localization.App.Service.Partners.KyivITCluster.Description,
                    ImageUrl = string.Format("{0}/content/images/logos/KyivITCluster.png", BaseUrl),
                    WebsiteUrl = "https://itcluster.kiev.ua/"
                },
                new Sponsor
                {
                    Name = AzureDay.WebApp.Localization.App.Service.Partners.ScrumUkraine.Title,
                    SponsorLevel = new SponsorLevel {Name = "Info", Rank = 3},
                    Description = AzureDay.WebApp.Localization.App.Service.Partners.ScrumUkraine.Description,
                    ImageUrl = string.Format("{0}/content/images/logos/scrum_ua.png", BaseUrl),
                    WebsiteUrl = "http://www.scrum.ua/"
                },
                new Sponsor
                {
                    Name = AzureDay.WebApp.Localization.App.Service.Partners.WeeklyIT.Title,
                    SponsorLevel = new SponsorLevel {Name = "Info", Rank = 3},
                    Description = AzureDay.WebApp.Localization.App.Service.Partners.WeeklyIT.Description,
                    ImageUrl = string.Format("{0}/content/images/logos/weeklyit.png", BaseUrl),
                    WebsiteUrl = "http://weekly-it.com/"
                },
                new Sponsor
                {
                    Name = AzureDay.WebApp.Localization.App.Service.Partners.DataScienceUA.Title,
                    Description = AzureDay.WebApp.Localization.App.Service.Partners.DataScienceUA.Description,
                    SponsorLevel = new SponsorLevel {Name = "Info", Rank = 3},
                    ImageUrl = string.Format("{0}/content/images/logos/DataScienceUA.png", BaseUrl),
                    WebsiteUrl = "https://data-science.com.ua/"                  
                },
                new Sponsor
                {
                    Name = AzureDay.WebApp.Localization.App.Service.Partners.DevDigest.Title,
                    Description = AzureDay.WebApp.Localization.App.Service.Partners.DevDigest.Description,
                    SponsorLevel = new SponsorLevel {Name = "Info", Rank = 3},
                    ImageUrl = string.Format("{0}/content/images/logos/devdigest.png", BaseUrl),
                    WebsiteUrl = "https://devdigest.today/"                 
                },
                new Sponsor
                {
                    Name = AzureDay.WebApp.Localization.App.Service.Partners.ITClusterVinnytsia.Title,
                    Description = AzureDay.WebApp.Localization.App.Service.Partners.ITClusterVinnytsia.Description,
                    SponsorLevel = new SponsorLevel {Name = "Info", Rank = 3},
                    ImageUrl = string.Format("{0}/content/images/logos/ITClusterVinnytsia.jpg", BaseUrl),
                    WebsiteUrl = "https://www.it-association.vn.ua/"
                },
                new Sponsor
                {
                    Name = AzureDay.WebApp.Localization.App.Service.Partners.Skyworker.Title,
                    Description = AzureDay.WebApp.Localization.App.Service.Partners.Skyworker.Description,
                    SponsorLevel = new SponsorLevel {Name = "Info", Rank = 3},
                    ImageUrl = string.Format("{0}/content/images/logos/Skyworker.jpg", BaseUrl),
                    WebsiteUrl = "https://skyworker.com.ua/",                    
                },
                new Sponsor
                {
                    Name = AzureDay.WebApp.Localization.App.Service.Partners.Ciklum.Title,
                    Description = AzureDay.WebApp.Localization.App.Service.Partners.Ciklum.Description,
                    SponsorLevel = new SponsorLevel {Name = "Silver", Rank = 1},
                    ImageUrl = string.Format("{0}/content/images/logos/ciklum_v3.png", BaseUrl),
                    WebsiteUrl = "https://www.ciklum.com/"
                },
                new Sponsor
                {
                    Name = AzureDay.WebApp.Localization.App.Service.Partners.DevPro.Title,
                    Description = AzureDay.WebApp.Localization.App.Service.Partners.DevPro.Description,
                    SponsorLevel = new SponsorLevel {Name = "Silver", Rank = 1},
                    ImageUrl = string.Format("{0}/content/images/logos/DevPro.png", BaseUrl),
                    WebsiteUrl = "https://www.dev-pro.net/"
                },
                new Sponsor
                {
                    Name = AzureDay.WebApp.Localization.App.Service.Partners.Wirex.Title,
                    Description = AzureDay.WebApp.Localization.App.Service.Partners.Wirex.Description,
                    SponsorLevel = new SponsorLevel {Name = "Bronze", Rank = 2},
                    ImageUrl = string.Format("{0}/content/images/logos/Wirex.png", BaseUrl),
                    WebsiteUrl = "https://wirexapp.com/"
                },
                new Sponsor
                {
                    Name = AzureDay.WebApp.Localization.App.Service.Partners.Salateira.Title,
                    Description = AzureDay.WebApp.Localization.App.Service.Partners.Salateira.Description,
                    SponsorLevel = new SponsorLevel {Name = "Info/Raffle", Rank = 3},
                    ImageUrl = string.Format("{0}/content/images/logos/salateira_v1.jpg", BaseUrl),
                    WebsiteUrl = "https://salateira.ua/"
                },
                new Sponsor
                {
                    Name = AzureDay.WebApp.Localization.App.Service.Partners.Eleks.Title,
                    Description = AzureDay.WebApp.Localization.App.Service.Partners.Eleks.Description,
                    SponsorLevel = new SponsorLevel {Name = "Silver", Rank = 1},
                    ImageUrl = string.Format("{0}/content/images/logos/ELEKS.png", BaseUrl),
                    WebsiteUrl = "https://eleks.com/",
                },
                new Sponsor
                {
                    Name = AzureDay.WebApp.Localization.App.Service.Partners.SmartIT.Title,
                    Description = AzureDay.WebApp.Localization.App.Service.Partners.SmartIT.Description,
                    SponsorLevel = new SponsorLevel {Name = "Info", Rank = 3},
                    ImageUrl = string.Format("{0}/content/images/logos/smart_it.jpg", BaseUrl),
                    WebsiteUrl = "http://www.smart-it.com/"           
                },
            };
        }
    }
}