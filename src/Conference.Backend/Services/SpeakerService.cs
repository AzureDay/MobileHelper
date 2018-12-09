using Conference.DataObjects;
using System.Collections.Generic;

namespace Conference.Backend.Services
{
    public class SpeakerService : BaseService<Speaker>
    {
        private readonly List<Speaker> _speakers = new List<Speaker>();
        private static string BaseUrl = "http://azuredaymobile-ru.azurewebsites.net";

        protected override List<Speaker> PopulateStorage()
        {
            _speakers.Add(AZhuravlev());
            _speakers.Add(VGusarov());
            _speakers.Add(DPetukhov());
            _speakers.Add(ALyubko());
            _speakers.Add(ASurkov());
            _speakers.Add(AErmakov());
            _speakers.Add(AChernevsky());
            _speakers.Add(AMosyagin());
            _speakers.Add(SSlukin());
            _speakers.Add(DLappo());
            _speakers.Add(DSoloviev());
            _speakers.Add(AButkevich());
            _speakers.Add(DKovrizhko());
            _speakers.Add(ATarasov());
            _speakers.Add(MMateev());

            #region Ukraine
            //_speakers.Add(ABoyko());
            //_speakers.Add(ILeontiev());
            //_speakers.Add(VTsykunov());
            //_speakers.Add(SBielskyi());
            //_speakers.Add(EAuberix());
            //_speakers.Add(SLebedenko());
            //_speakers.Add(ASurkov());
            //_speakers.Add(SSultanov());
            //_speakers.Add(EPolonychko());
            //_speakers.Add(EWasilewski());
            //_speakers.Add(AVidishchev());
            //_speakers.Add(SPoplavskiy());
            //_speakers.Add(OKrakovetskyi());
            //_speakers.Add(NDranchuk());
            //_speakers.Add(KBaczyk());
            //_speakers.Add(ILubenets());
            //_speakers.Add(NMykhailenko());
            #endregion Ukraine

            return _speakers;
        }

        public Speaker MMateev()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.MMateev.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.MMateev.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.MMateev.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/MMateev.jpg", BaseUrl),
                LinkedInUrl = "https://www.linkedin.com/in/mmateev/",
                TwitterUrl = "https://twitter.com/mihailmateev",
                CompanyName = "Microsoft",
                PositionName = "Microsoft Regional Director",
                AvatarUrl = string.Format("{0}/content/images/avatars/MMateev.jpg", BaseUrl),
                CompanyWebsiteUrl = "https://www.microsoft.com/ru-ru/",
            };
        }

        public Speaker ATarasov()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.ATarasov.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.ATarasov.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.ATarasov.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/ATarasov.jpg", BaseUrl),
                LinkedInUrl = "https://www.linkedin.com/in/arsenytarasov/",
                TwitterUrl = "",
                CompanyName = "Microsoft",
                PositionName = "Digital Transformation Lead, advisor to customer CDO",
                AvatarUrl = string.Format("{0}/content/images/avatars/ATarasov.jpg", BaseUrl),
                CompanyWebsiteUrl = "https://www.microsoft.com/ru-ru/",
            };
        }

        public Speaker DKovrizhko()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.DKovrizhko.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.DKovrizhko.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.DKovrizhko.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/DKovrizhko.jpg", BaseUrl),
                LinkedInUrl = "https://www.linkedin.com/in/dmitry-kovrizhko-9107b7b/",
                TwitterUrl = "",
                CompanyName = "ISDK",
                PositionName = "CEO",
                AvatarUrl = string.Format("{0}/content/images/avatars/DKovrizhko.jpg", BaseUrl),
                CompanyWebsiteUrl = "https://isdk.pro/",
            };
        }

        public Speaker AButkevich()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.AButkevich.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.AButkevich.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.AButkevich.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/AButkevich.jpg", BaseUrl),
                LinkedInUrl = "",
                TwitterUrl = "",
                CompanyName = "Awara Group",
                PositionName = "Специалист по внедрениям Microsoft 365",
                AvatarUrl = string.Format("{0}/content/images/avatars/AButkevich.jpg", BaseUrl),
                CompanyWebsiteUrl = "http://www.awaragroup.com/",
            };
        }

        public Speaker DSoloviev()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.DSoloviev.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.DSoloviev.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.DSoloviev.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/DSoloviev.png", BaseUrl),
                LinkedInUrl = "",
                TwitterUrl = "",
                CompanyName = "Астрософт",
                PositionName = "Руководитель направления Microsoft Power BI",
                AvatarUrl = string.Format("{0}/content/images/avatars/DSoloviev.png", BaseUrl),
                CompanyWebsiteUrl = "https://www.astrosoft.ru/",
            };
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
                CompanyName = "ASBIS BY",
                PositionName = "Azure MVP & Microsoft Certified Trainer",
                AvatarUrl = string.Format("{0}/content/images/avatars/DLappo.png", BaseUrl),
                CompanyWebsiteUrl = "http://www.asbis.by/",
            };
        }

        public Speaker SSlukin()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.SSlukin.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.SSlukin.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.SSlukin.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/sslukin.jpg", BaseUrl),
                LinkedInUrl = "https://www.linkedin.com/in/sslukin/",
                TwitterUrl = "",
                CompanyName = "TerraLink",
                PositionName = "Microsoft technologies Consultant, Trainer, Architect",
                AvatarUrl = string.Format("{0}/content/images/avatars/sslukin.jpg", BaseUrl),
                CompanyWebsiteUrl = "http://terralink-global.com/",
            };
        }

        public Speaker AMosyagin()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.AMosyagin.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.AMosyagin.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.AMosyagin.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/AMosyagin.jpg", BaseUrl),
                LinkedInUrl = "https://www.linkedin.com/in/antonmosyagin/",
                TwitterUrl = "",
                CompanyName = "Rambler&Co",
                PositionName = "System Engineer",
                AvatarUrl = string.Format("{0}/content/images/avatars/AMosyagin.jpg", BaseUrl),
                CompanyWebsiteUrl = "https://rambler-co.ru/",
            };
        }

        public Speaker AChernevsky()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.AChernevsky.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.AChernevsky.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.AChernevsky.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/AChernevsky.jpg", BaseUrl),
                LinkedInUrl = "https://www.linkedin.com/in/chernevsky/",
                TwitterUrl = "",
                CompanyName = "iTrainer365",
                PositionName = "CEO",
                AvatarUrl = string.Format("{0}/content/images/avatars/AChernevsky.jpg", BaseUrl),
                CompanyWebsiteUrl = "http://www.videouniver.ru/",
            };
        }

        public Speaker AErmakov()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.AErmakov.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.AErmakov.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.AErmakov.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/AErmakov.jpg", BaseUrl),
                LinkedInUrl = "https://www.linkedin.com/in/alexander-ermakov-2b32b326/",
                TwitterUrl = "",
                CompanyName = "Awara Group",
                PositionName = "Director of ERP Unit, Partner",
                AvatarUrl = string.Format("{0}/content/images/avatars/AErmakov.jpg", BaseUrl),
                CompanyWebsiteUrl = "http://www.awaragroup.com/",
            };
        }

        public Speaker ASurkov()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.ASurkov.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.ASurkov.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.ASurkov.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/ASurkov.jpg", BaseUrl),
                LinkedInUrl = "https://www.linkedin.com/in/aosurkov/",
                TwitterUrl = "https://twitter.com/AOSurkov",
                CompanyName = "Yandex",
                PositionName = "Architect",
                AvatarUrl = string.Format("{0}/content/images/avatars/ASurkov.jpg", BaseUrl),
                CompanyWebsiteUrl = "http://company.yandex.com/",
            };
        }

        public Speaker ALyubko()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.ALyubko.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.ALyubko.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.ALyubko.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/ALyubko.png", BaseUrl),
                LinkedInUrl = "https://www.linkedin.com/in/alyubko/",
                TwitterUrl = "",
                CompanyName = "Pryaniky.com",
                PositionName = "CEO",
                AvatarUrl = string.Format("{0}/content/images/avatars/ALyubko.png", BaseUrl),
                CompanyWebsiteUrl = "https://latoken.com/",
            };
        }

        public Speaker DPetukhov()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.DPetukhov.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.DPetukhov.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.DPetukhov.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/DPetukhov.jpg", BaseUrl),
                LinkedInUrl = "https://www.linkedin.com/in/dpetukhov/",
                TwitterUrl = "",
                CompanyName = "LATOKEN",
                PositionName = "Microsoft AI MVP",
                AvatarUrl = string.Format("{0}/content/images/avatars/DPetukhov.jpg", BaseUrl),
                CompanyWebsiteUrl = "https://latoken.com/",
            };
        }

        public Speaker VGusarov()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.VGusarov.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.VGusarov.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.VGusarov.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/VGusarov.png", BaseUrl),
                LinkedInUrl = "https://www.linkedin.com/in/hussar/",
                TwitterUrl = "",
                CompanyName = "One Identity",
                PositionName = "Software Engineer Director",
                AvatarUrl = string.Format("{0}/content/images/avatars/VGusarov.png", BaseUrl),
                CompanyWebsiteUrl = "https://www.oneidentity.com/",
            };
        }

        public Speaker AZhuravlev()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.AZhuravlev.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.AZhuravlev.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.AZhuravlev.Bio,
                PhotoUrl = string.Format("{0}/content/images/avatars/AZhuravlev.jpg", BaseUrl),
                LinkedInUrl = "https://www.linkedin.com/in/azhure/",
                TwitterUrl = "",
                CompanyName = "UCLAB",
                PositionName = "Руководитель лаборатории UCLAB",
                AvatarUrl = string.Format("{0}/content/images/avatars/AZhuravlev.jpg", BaseUrl),
                CompanyWebsiteUrl = "http://uclab.ru/",
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
        }*/
        #endregion Ukraine
    }
}