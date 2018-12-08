using Conference.DataObjects;
using System.Collections.Generic;

namespace Conference.Backend.Services
{
    public class SpeakerService : BaseService<Speaker>
    {
        private readonly List<Speaker> _speakers = new List<Speaker>();
        private static string BaseUrl = "http://azuredaymobile-by.azurewebsites.net";

        protected override List<Speaker> PopulateStorage()
        {
            _speakers.Add(AKozhemiakin());
            _speakers.Add(ALaysha());
            _speakers.Add(RNovik());
            _speakers.Add(UKastelic());
            _speakers.Add(ABoyko());
            _speakers.Add(ARamanchyk());
            _speakers.Add(LDauhiala());
            _speakers.Add(EBogdanov());
            _speakers.Add(AIvlev());
            _speakers.Add(KSultanov());
            _speakers.Add(DLappo());
            #region Ukraine
            /*_speakers.Add(ABoyko());
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
            _speakers.Add(SPoplavskiy());
            _speakers.Add(OKrakovetskyi());
            _speakers.Add(NDranchuk());
            _speakers.Add(KBaczyk());
            _speakers.Add(ILubenets());
            _speakers.Add(NMykhailenko());*/
            #endregion Ukraine

            return _speakers;
        }

        public Speaker DLappo()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.DLappo.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.DLappo.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.DLappo.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/DLappo.png", BaseUrl),
                LinkedInUrl = "",
                TwitterUrl = "",
                CompanyName = "ASBIS Belarus",
                PositionName = "Cloud Solutions Architect",
                AvatarUrl = string.Format("{0}/content/images/avatars/DLappo.png", BaseUrl),
                CompanyWebsiteUrl = "http://www.asbis.by/",
            };
        }

        public Speaker KSultanov()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.KSultanov.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.KSultanov.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.KSultanov.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/KSultanov.jpeg", BaseUrl),
                LinkedInUrl = "",
                TwitterUrl = "",
                CompanyName = "EPAM Systems",
                PositionName = "Big Data Engineer & Solution Architect",
                AvatarUrl = string.Format("{0}/content/images/avatars/KSultanov.jpeg", BaseUrl),
                CompanyWebsiteUrl = "https://www.epam.com/",
            };
        }

        public Speaker AIvlev()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.AIvlev.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.AIvlev.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.AIvlev.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/AIvlev.jpg", BaseUrl),
                LinkedInUrl = "",
                TwitterUrl = "",
                CompanyName = "EPAM Systems",
                PositionName = "Systems Engineer",
                AvatarUrl = string.Format("{0}/content/images/avatars/AIvlev.jpg", BaseUrl),
                CompanyWebsiteUrl = "https://www.epam.com/",
            };
        }

        public Speaker EBogdanov()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.EBogdanov.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.EBogdanov.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.EBogdanov.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/EBogdanov.jpg", BaseUrl),
                LinkedInUrl = "",
                TwitterUrl = "",
                CompanyName = "EPAM Systems",
                PositionName = "Senior Systems Engineer",
                AvatarUrl = string.Format("{0}/content/images/avatars/EBogdanov.jpg", BaseUrl),
                CompanyWebsiteUrl = "https://www.epam.com/",
            };
        }

        public Speaker LDauhiala()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.LDauhiala.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.LDauhiala.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.LDauhiala.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/LDauhiala.jpg", BaseUrl),
                LinkedInUrl = "",
                TwitterUrl = "",
                CompanyName = "EPAM Systems",
                PositionName = "Data Scientist",
                AvatarUrl = string.Format("{0}/content/images/avatars/LDauhiala.jpg", BaseUrl),
                CompanyWebsiteUrl = "https://www.epam.com/",
            };
        }

        public Speaker ARamanchyk()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.ARamanchyk.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.ARamanchyk.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.ARamanchyk.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/ARamanchyk.jpg", BaseUrl),
                LinkedInUrl = "",
                TwitterUrl = "",
                CompanyName = "EPAM Systems",
                PositionName = "Senior Systems Engineer",
                AvatarUrl = string.Format("{0}/content/images/avatars/ARamanchyk.jpg", BaseUrl),
                CompanyWebsiteUrl = "https://www.epam.com/",
            };
        }

        public Speaker ABoyko()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.ABoyko.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.ABoyko.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.ABoyko.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/ABoyko.jpg", BaseUrl),
                LinkedInUrl = "",
                TwitterUrl = "",
                CompanyName = "Ciklum",
                PositionName = "Solution Architect",
                AvatarUrl = string.Format("{0}/content/images/avatars/ABoyko.jpg", BaseUrl),
                CompanyWebsiteUrl = "https://www.ciklum.com/",
            };
        }

        public Speaker UKastelic()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.UKastelic.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.UKastelic.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.UKastelic.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/UKastelic.jpeg", BaseUrl),
                LinkedInUrl = "",
                TwitterUrl = "",
                CompanyName = "Microsoft",
                PositionName = "Technology Solutions Professional for Azure Application Development",
                AvatarUrl = string.Format("{0}/content/images/avatars/UKastelic.jpeg", BaseUrl),
                CompanyWebsiteUrl = "https://www.microsoft.com/",
            };
        }

        public Speaker RNovik()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.RNovik.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.RNovik.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.RNovik.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/RNovik.jpeg", BaseUrl),
                LinkedInUrl = "",
                TwitterUrl = "",
                CompanyName = "EPAM Systems",
                PositionName = "Solution Architect, Big Data Competency Center",
                AvatarUrl = string.Format("{0}/content/images/avatars/RNovik.jpeg", BaseUrl),
                CompanyWebsiteUrl = "https://www.epam.com/",
            };
        }

        public Speaker ALaysha()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.ALaysha.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.ALaysha.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.ALaysha.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/ALaysha.png", BaseUrl),
                LinkedInUrl = "",
                TwitterUrl = "",
                CompanyName = "EPAM Systems",
                PositionName = "Solution Architect, Big Data Competency Center",
                AvatarUrl = string.Format("{0}/content/images/avatars/ALaysha.png", BaseUrl),
                CompanyWebsiteUrl = "https://www.epam.com/",
            };
        }

        public Speaker AKozhemiakin()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.AKozhemiakin.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.AKozhemiakin.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.AKozhemiakin.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/AKozhemiakin.jpg", BaseUrl),
                LinkedInUrl = "",
                TwitterUrl = "",
                CompanyName = "EPAM Systems",
                PositionName = "Director, Big Data Competency Center",
                AvatarUrl = string.Format("{0}/content/images/avatars/AKozhemiakin.jpg", BaseUrl),
                CompanyWebsiteUrl = "https://www.epam.com/",
            };
        }

        #region Ukraine
        /*public Speaker ABoyko()
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

        public Speaker NMykhailenko()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.NMykhailenko.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.NMykhailenko.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.NMykhailenko.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/NMykhailenko.png", BaseUrl),
                LinkedInUrl = "https://www.linkedin.com/in/nikita-mykhailenko/",
                TwitterUrl = "",
                CompanyName = "",
                PositionName = "Software Engineer",
                AvatarUrl = string.Format("{0}/content/images/avatars/NMykhailenko.png", BaseUrl),
                CompanyWebsiteUrl = "",
            };
        } */
        #endregion Ukraine
    }
}