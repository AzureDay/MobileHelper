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
                    SponsorLevel = new SponsorLevel {Name = "Info", Rank = 1},
                    Description = AzureDay.WebApp.Localization.App.Service.Partners.Beetroot.Description,
                    ImageUrl = string.Format("{0}/content/images/logos/Beetroot_v1.png", BaseUrl),
                    WebsiteUrl = "https://beetroot.se/"
                },
                new Sponsor
                {
                    Name = AzureDay.WebApp.Localization.App.Service.Partners.Bodo.Title,
                    SponsorLevel = new SponsorLevel {Name = "Info", Rank = 1},
                    Description = AzureDay.WebApp.Localization.App.Service.Partners.Bodo.Description,
                    ImageUrl = string.Format("{0}/content/images/logos/bodo.png", BaseUrl),
                    WebsiteUrl = "https://www.bodo.ua/"
                },
                new Sponsor
                {
                    Name = AzureDay.WebApp.Localization.App.Service.Partners.BrainBasket.Title,
                    SponsorLevel = new SponsorLevel {Name = "Info", Rank = 1},
                    Description = AzureDay.WebApp.Localization.App.Service.Partners.BrainBasket.Description,
                    ImageUrl = string.Format("{0}/content/images/logos/BrainBasketFoundation_v1.png", BaseUrl),
                    WebsiteUrl = "https://brainbasket.org/"
                },
                new Sponsor
                {
                    Name = AzureDay.WebApp.Localization.App.Service.Partners.BrainTV.Title,
                    SponsorLevel = new SponsorLevel {Name = "Info", Rank = 1},
                    Description = AzureDay.WebApp.Localization.App.Service.Partners.BrainTV.Description,
                    ImageUrl = string.Format("{0}/content/images/logos/brain_tv.jpg", BaseUrl),
                    WebsiteUrl = "https://braintv.net/"
                },
                new Sponsor
                {
                    Name = AzureDay.WebApp.Localization.App.Service.Partners.DevArt.Title,
                    SponsorLevel = new SponsorLevel {Name = "Info", Rank = 1},
                    Description = AzureDay.WebApp.Localization.App.Service.Partners.DevArt.Description,
                    ImageUrl = string.Format("{0}/content/images/logos/devart_v1.png", BaseUrl),
                    WebsiteUrl = "https://www.devart.com/"
                },
                new Sponsor
                {
                    Name = AzureDay.WebApp.Localization.App.Service.Partners.Dou.Title,
                    SponsorLevel = new SponsorLevel {Name = "Info", Rank = 1},
                    Description = AzureDay.WebApp.Localization.App.Service.Partners.Dou.Description,
                    ImageUrl = string.Format("{0}/content/images/logos/dou.png", BaseUrl),
                    WebsiteUrl = "https://dou.ua/"
                },
                new Sponsor
                {
                    Name = AzureDay.WebApp.Localization.App.Service.Partners.ITClusterKonotop.Title,
                    SponsorLevel = new SponsorLevel {Name = "Info", Rank = 1},
                    Description = AzureDay.WebApp.Localization.App.Service.Partners.ITClusterKonotop.Description,
                    ImageUrl = string.Format("{0}/content/images/logos/itclusterkonotop_v1.png", BaseUrl),
                    WebsiteUrl = "http://itcluster.konotop.info/"
                },
                new Sponsor
                {
                    Name = AzureDay.WebApp.Localization.App.Service.Partners.ITRatingUkraine.Title,
                    SponsorLevel = new SponsorLevel {Name = "Info", Rank = 1},
                    Description = AzureDay.WebApp.Localization.App.Service.Partners.ITRatingUkraine.Description,
                    ImageUrl = string.Format("{0}/content/images/logos/itratingsukraine_v1.png", BaseUrl),
                    WebsiteUrl = "https://it-rating.in.ua/"
                },
                new Sponsor
                {
                    Name = AzureDay.WebApp.Localization.App.Service.Partners.KyivITCluster.Title,
                    SponsorLevel = new SponsorLevel {Name = "Info", Rank = 1},
                    Description = AzureDay.WebApp.Localization.App.Service.Partners.KyivITCluster.Description,
                    ImageUrl = string.Format("{0}/content/images/logos/KyivITCluster.png", BaseUrl),
                    WebsiteUrl = "https://itcluster.kiev.ua/"
                },
                new Sponsor
                {
                    Name = AzureDay.WebApp.Localization.App.Service.Partners.ScrumUkraine.Title,
                    SponsorLevel = new SponsorLevel {Name = "Info", Rank = 1},
                    Description = AzureDay.WebApp.Localization.App.Service.Partners.ScrumUkraine.Description,
                    ImageUrl = string.Format("{0}/content/images/logos/scrum_ua.png", BaseUrl),
                    WebsiteUrl = "http://www.scrum.ua/"
                },
                new Sponsor
                {
                    Name = AzureDay.WebApp.Localization.App.Service.Partners.WeeklyIT.Title,
                    SponsorLevel = new SponsorLevel {Name = "Info", Rank = 1},
                    Description = AzureDay.WebApp.Localization.App.Service.Partners.WeeklyIT.Description,
                    ImageUrl = string.Format("{0}/content/images/logos/weeklyit.png", BaseUrl),
                    WebsiteUrl = "http://weekly-it.com/"
                },
            };
        }
    }
}