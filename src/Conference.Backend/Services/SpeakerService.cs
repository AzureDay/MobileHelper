using Conference.DataObjects;
using System.Collections.Generic;

namespace Conference.Backend.Services
{
    public class SpeakerService : BaseService<Speaker>
    {
        private readonly List<Speaker> _speakers = new List<Speaker>();
        private static string BaseUrl = "http://azuredaymobile.azurewebsites.net";

        protected override List<Speaker> PopulateStorage()
        {
            _speakers.Add(ABoyko());
            _speakers.Add(ILeontiev());
            _speakers.Add(VTsykunov());
            _speakers.Add(SBielskyi());
            _speakers.Add(EAuberix());
            _speakers.Add(SLebedenko());
            _speakers.Add(ASurkov());
            _speakers.Add(SSultanov());
            _speakers.Add(EPolonychko());
            _speakers.Add(EWasilewski());
            _speakers.Add(AVidishchev());
            _speakers.Add(OKrakovetskyi());
            _speakers.Add(ILubenets());
            _speakers.Add(KBaczyk());
            _speakers.Add(NDranchuk());
            _speakers.Add(SPoplavskiy());

            return _speakers;
        }

        public Speaker ABoyko()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.ABoyko.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.ABoyko.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.ABoyko.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/ABoyko.jpg", BaseUrl),
                LinkedInUrl = "https://www.linkedin.com/in/boykoant/",
                TwitterUrl = "https://twitter.com/BoykoAnt",
                CompanyName = "Ciklum",
                PositionName = "Solution Architect",
                AvatarUrl = string.Format("{0}/content/images/avatars/ABoyko.jpg", BaseUrl),
                CompanyWebsiteUrl = "https://www.ciklum.com/",
            };
        }

        public Speaker ILeontiev()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.ILeontiev.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.ILeontiev.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.ILeontiev.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/ILeontyev.jpg", BaseUrl),
                LinkedInUrl = "https://www.linkedin.com/in/leontievihor/",
                TwitterUrl = "",
                CompanyName = "Viseo group",
                PositionName = "Lead Architect",
                AvatarUrl = string.Format("{0}/content/images/avatars/ILeontyev.jpg", BaseUrl),
                CompanyWebsiteUrl = "https://www.viseo.com/en",
            };
        }

        public Speaker VTsykunov()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.VTsykunov.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.VTsykunov.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.VTsykunov.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/VTsykunov.jpg", BaseUrl),
                LinkedInUrl = "",
                TwitterUrl = "",
                CompanyName = "Microsoft",
                PositionName = "Partner Business Evangelist",
                AvatarUrl = string.Format("{0}/content/images/avatars/VTsykunov.jpg", BaseUrl),
                CompanyWebsiteUrl = "https://www.microsoft.com/uk-ua/",
            };
        }

        public Speaker SBielskyi()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.SBielskyi.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.SBielskyi.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.SBielskyi.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/SergiiBielskyi.jpg", BaseUrl),
                LinkedInUrl = "https://www.linkedin.com/in/sergii-bielskyi-884a7a2b/",
                TwitterUrl = "",
                CompanyName = "qiio",
                PositionName = "Cloud Solution Architect",
                AvatarUrl = string.Format("{0}/content/images/avatars/SergiiBielskyi.jpg", BaseUrl),
                CompanyWebsiteUrl = "https://qiio.com/",
            };
        }

        public Speaker EAuberix()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.EAuberix.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.EAuberix.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.EAuberix.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/EAuberix.jpg", BaseUrl),
                LinkedInUrl = "https://www.linkedin.com/in/estelleauberix/",
                TwitterUrl = "https://twitter.com/FollowEstelle",
                CompanyName = "ITERFACIO",
                PositionName = "CEO, Founder",
                AvatarUrl = string.Format("{0}/content/images/avatars/EAuberix.jpg", BaseUrl),
                CompanyWebsiteUrl = "http://www.iterfacio.fr/",
            };
        }

        public Speaker SLebedenko()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.SLebedenko.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.SLebedenko.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.SLebedenko.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/LebedenkoStas.jpg", BaseUrl),
                LinkedInUrl = "https://www.linkedin.com/in/lebedenkostanislav/",
                TwitterUrl = "",
                CompanyName = "Sigma Software Group",
                PositionName = ".NET Developer",
                AvatarUrl = string.Format("{0}/content/images/avatars/LebedenkoStas.jpg", BaseUrl),
                CompanyWebsiteUrl = "https://sigma.software/",
            };
        }

        public Speaker ASurkov()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.ASurkov.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.ASurkov.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.ASurkov.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/AOSurkov.png", BaseUrl),
                LinkedInUrl = "https://www.linkedin.com/in/aosurkov/",
                TwitterUrl = "https://twitter.com/AOSurkov",
                CompanyName = "Yandex",
                PositionName = "Architect",
                AvatarUrl = string.Format("{0}/content/images/avatars/AOSurkov.png", BaseUrl),
                CompanyWebsiteUrl = "http://company.yandex.com/",
            };
        }

        public Speaker SSultanov()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.SSultanov.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.SSultanov.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.SSultanov.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/StasSultanov.jpg", BaseUrl),
                LinkedInUrl = "https://www.linkedin.com/in/stas-sultanov/",
                TwitterUrl = "",
                CompanyName = "Ciklum",
                PositionName = "Cloud Solutions Archictect",
                AvatarUrl = string.Format("{0}/content/images/avatars/StasSultanov.jpg", BaseUrl),
                CompanyWebsiteUrl = "https://www.ciklum.com/",
            };
        }

        public Speaker EPolonychko()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.EPolonychko.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.EPolonychko.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.EPolonychko.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/EPolonychko.jpg", BaseUrl),
                LinkedInUrl = "",
                TwitterUrl = "",
                CompanyName = "ELEKS",
                PositionName = "Senior Software Developer",
                AvatarUrl = string.Format("{0}/content/images/avatars/EPolonychko.jpg", BaseUrl),
                CompanyWebsiteUrl = "https://eleks.com/",
            };
        }

        public Speaker EWasilewski()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.EWasilewski.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.EWasilewski.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.EWasilewski.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/EmilWasilewski2.png", BaseUrl),
                LinkedInUrl = "http://www.linkedin.com/in/emilwasilewski",
                TwitterUrl = "https://twitter.com/WasilewskiEmil",
                CompanyName = "Bystronic Group",
                PositionName = "Senior Azure Infrastructure Architect",
                AvatarUrl = string.Format("{0}/content/images/avatars/EmilWasilewski2.png", BaseUrl),
                CompanyWebsiteUrl = "https://www.bystronic.com/en/",
            };
        }

        public Speaker AVidishchev()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.AVidishchev.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.AVidishchev.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.AVidishchev.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/AVidishchev.jpg", BaseUrl),
                LinkedInUrl = "https://www.linkedin.com/in/antonvidishchev",
                TwitterUrl = "",
                CompanyName = "SoftServe",
                PositionName = "Azure Architect",
                AvatarUrl = string.Format("{0}/content/images/avatars/AVidishchev.jpg", BaseUrl),
                CompanyWebsiteUrl = "https://www.softserveinc.com/en-us/",
            };
        }

        public Speaker OKrakovetskyi()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.OKrakovetskyi.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.OKrakovetskyi.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.OKrakovetskyi.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/OKrakovetskyi.jpg", BaseUrl),
                LinkedInUrl = "https://www.linkedin.com/in/krakovetskiy/",
                TwitterUrl = "https://twitter.com/msugvnua",
                CompanyName = "DevRain Solutions",
                PositionName = "CEO",
                AvatarUrl = string.Format("{0}/content/images/avatars/OKrakovetskyi.jpg", BaseUrl),
                CompanyWebsiteUrl = "http://devrain.com/",
            };
        }

        public Speaker SPoplavskiy()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.SPoplavskiy.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.SPoplavskiy.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.SPoplavskiy.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/SPoplavskiy.png", BaseUrl),
                LinkedInUrl = "",
                TwitterUrl = "",
                CompanyName = "Microsoft",
                PositionName = "Microsoft Azure Software Developer",
                AvatarUrl = string.Format("{0}/content/images/avatars/SPoplavskiy.png", BaseUrl),
                CompanyWebsiteUrl = "https://www.microsoft.com/uk-ua/",
            };
        }

        public Speaker NDranchuk()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.NDranchuk.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.NDranchuk.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.NDranchuk.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/NDranchuk.jpg", BaseUrl),
                LinkedInUrl = "https://www.linkedin.com/in/nataliia-dranchuk-0618b0107/",
                TwitterUrl = "",
                CompanyName = "Smart Business",
                PositionName = ".NET developer",
                AvatarUrl = string.Format("{0}/content/images/avatars/NDranchuk.jpg", BaseUrl),
                CompanyWebsiteUrl = "http://smart-it.com/",
            };
        }

        public Speaker KBaczyk()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.KBaczyk.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.KBaczyk.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.KBaczyk.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/KBaczyk.jpg", BaseUrl),
                LinkedInUrl = "https://www.linkedin.com/in/kamil-b%C4%85czyk-32093714/",
                TwitterUrl = "https://twitter.com/kamilbaczyk",
                CompanyName = "Microsoft",
                PositionName = "Microsoft MVP Profile and Public Speaking info",
                AvatarUrl = string.Format("{0}/content/images/avatars/KBaczyk.jpg", BaseUrl),
                CompanyWebsiteUrl = "https://www.microsoft.com/uk-ua/",
            };
        }

        public Speaker ILubenets()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.ILubenets.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.ILubenets.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.ILubenets.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/ILubenets.jpg", BaseUrl),
                LinkedInUrl = "https://www.linkedin.com/in/illia-lubenets-b16b15b6/",
                TwitterUrl = "",
                CompanyName = "Aistant",
                PositionName = "Senior Software Engineer Team Lead",
                AvatarUrl = string.Format("{0}/content/images/avatars/ILubenets.jpg", BaseUrl),
                CompanyWebsiteUrl = "https://aistant.com/",
            };
        }
    }
}