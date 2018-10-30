using Conference.DataObjects;
using System.Collections.Generic;
using System.Linq;

namespace Conference.Backend.Services
{
    public class SpeakerService : BaseService<Speaker>
    {
        private readonly List<Speaker> _speakers = new List<Speaker>();

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
            _speakers.Add(VBezmaly());
            _speakers.Add(OKrakovetskyi());

            return _speakers;
        }

        public Speaker ABoyko()
        {
            return new Speaker
            {
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.ABoyko.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.ABoyko.LastName,
                Biography = AzureDay.WebApp.Localization.App.Service.Speaker.ABoyko.Bio,
                PhotoUrl = "{0}/content/images/avatars/ABoyko.jpg",
                LinkedInUrl = "https://www.linkedin.com/in/boykoant/",
                TwitterUrl = "https://twitter.com/BoykoAnt",
                CompanyName = "Ciklum",
                PositionName = "Solution Architect",
                AvatarUrl = "{0}/content/images/avatars/ABoyko.jpg",
                CompanyWebsiteUrl = "https://www.ciklum.com/",
            };
        }

        public Speaker ILeontiev()
        {
            return new Speaker
            {
                Id = "ILeontiev",
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.ILeontiev.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.ILeontiev.LastName,
                Bio = AzureDay.WebApp.Localization.App.Service.Speaker.ILeontiev.Bio.Replace(Environment.NewLine, "<br/>"),
                Country = _countryService.Ukraine,
                PhotoUrl = "/images/avatars/ILeontyev.jpg",
                FacebookUrl = "",
                GitHubUrl = "",
                GoogleUrl = "",
                LinkedInUrl = "https://www.linkedin.com/in/leontievihor/",
                MsdnUrl = "",
                MvpUrl = "",
                TwitterUrl = "",
                YouTubeUrl = "",
                WebUrl = "",
                CompanyName = "Viseo group",
                JobTitle = "Lead Architect"
            };
        }

        public SpeakerEntity VTsykunov()
        {
            return new SpeakerEntity
            {
                Id = "VTsykunov",
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.VTsykunov.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.VTsykunov.LastName,
                Bio = AzureDay.WebApp.Localization.App.Service.Speaker.VTsykunov.Bio.Replace(Environment.NewLine, "<br/>"),
                Country = _countryService.Ukraine,
                PhotoUrl = "/images/avatars/VTsykunov.jpg",
                FacebookUrl = "https://www.facebook.com/vtsykunov",
                GitHubUrl = "",
                GoogleUrl = "",
                LinkedInUrl = "",
                MsdnUrl = "",
                MvpUrl = "",
                TwitterUrl = "",
                YouTubeUrl = "",
                WebUrl = "",
                CompanyName = "Microsoft",
                JobTitle = "Partner Business Evangelist"
            };
        }

        public SpeakerEntity SBielskyi()
        {
            return new SpeakerEntity
            {
                Id = "SBielskyi",
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.SBielskyi.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.SBielskyi.LastName,
                Bio = AzureDay.WebApp.Localization.App.Service.Speaker.SBielskyi.Bio.Replace(Environment.NewLine, "<br/>"),
                Country = _countryService.Ukraine,
                PhotoUrl = "/images/avatars/SergiiBielskyi.jpg",
                FacebookUrl = "",
                GitHubUrl = "",
                GoogleUrl = "",
                LinkedInUrl = "https://www.linkedin.com/in/sergii-bielskyi-884a7a2b/",
                MsdnUrl = "",
                MvpUrl = "",
                TwitterUrl = "",
                YouTubeUrl = "",
                WebUrl = "",
                CompanyName = "qiio",
                JobTitle = "Cloud Solution Architect"
            };
        }

        public SpeakerEntity EAuberix()
        {
            return new SpeakerEntity
            {
                Id = "EAuberix",
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.EAuberix.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.EAuberix.LastName,
                Bio = AzureDay.WebApp.Localization.App.Service.Speaker.EAuberix.Bio.Replace(Environment.NewLine, "<br/>"),
                Country = _countryService.France,
                PhotoUrl = "/images/avatars/EAuberix.jpg",
                FacebookUrl = "",
                GitHubUrl = "",
                GoogleUrl = "",
                LinkedInUrl = "https://www.linkedin.com/in/estelleauberix/",
                MsdnUrl = "",
                MvpUrl = "",
                TwitterUrl = "https://twitter.com/FollowEstelle",
                YouTubeUrl = "",
                WebUrl = "",
                CompanyName = "ITERFACIO",
                JobTitle = "CEO, Founder"
            };
        }

        public SpeakerEntity SLebedenko()
        {
            return new SpeakerEntity
            {
                Id = "SLebedenko",
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.SLebedenko.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.SLebedenko.LastName,
                Bio = AzureDay.WebApp.Localization.App.Service.Speaker.SLebedenko.Bio.Replace(Environment.NewLine, "<br/>"),
                Country = _countryService.Ukraine,
                PhotoUrl = "/images/avatars/LebedenkoStas.jpg",
                FacebookUrl = "",
                GitHubUrl = "",
                GoogleUrl = "",
                LinkedInUrl = "https://www.linkedin.com/in/lebedenkostanislav/",
                MsdnUrl = "",
                MvpUrl = "",
                TwitterUrl = "",
                YouTubeUrl = "",
                WebUrl = "",
                CompanyName = "Sigma Software Group",
                JobTitle = ".NET Developer"
            };
        }

        public SpeakerEntity ASurkov()
        {
            return new SpeakerEntity
            {
                Id = "ASurkov",
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.ASurkov.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.ASurkov.LastName,
                Bio = AzureDay.WebApp.Localization.App.Service.Speaker.ASurkov.Bio.Replace(Environment.NewLine, "<br/>"),
                Country = _countryService.Russia,
                PhotoUrl = "/images/avatars/AOSurkov.png",
                FacebookUrl = "https://www.facebook.com/AOSurkov",
                GitHubUrl = "",
                GoogleUrl = "",
                LinkedInUrl = "https://www.linkedin.com/in/aosurkov/",
                MsdnUrl = "",
                MvpUrl = "https://mvp.microsoft.com/ru-ru/PublicProfile/5002197",
                TwitterUrl = "https://twitter.com/AOSurkov",
                YouTubeUrl = "",
                WebUrl = "",
                CompanyName = "Yandex",
                JobTitle = "Architect"
            };
        }

        public SpeakerEntity SSultanov()
        {
            return new SpeakerEntity
            {
                Id = "SSultanov",
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.SSultanov.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.SSultanov.LastName,
                Bio = AzureDay.WebApp.Localization.App.Service.Speaker.SSultanov.Bio.Replace(Environment.NewLine, "<br/>"),
                Country = _countryService.Ukraine,
                PhotoUrl = "/images/avatars/StasSultanov.jpg",
                FacebookUrl = "",
                GitHubUrl = "",
                GoogleUrl = "",
                LinkedInUrl = "https://www.linkedin.com/in/stas-sultanov/",
                MsdnUrl = "",
                MvpUrl = "",
                TwitterUrl = "",
                YouTubeUrl = "",
                WebUrl = "",
                CompanyName = "Ciklum",
                JobTitle = "Cloud Solutions Archictect"
            };
        }

        public SpeakerEntity EPolonychko()
        {
            return new SpeakerEntity
            {
                Id = "EPolonychko",
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.EPolonychko.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.EPolonychko.LastName,
                Bio = AzureDay.WebApp.Localization.App.Service.Speaker.EPolonychko.Bio.Replace(Environment.NewLine, "<br/>"),
                Country = _countryService.Ukraine,
                PhotoUrl = "/images/avatars/EPolonychko.jpg",
                FacebookUrl = "https://www.facebook.com/mydjeki",
                GitHubUrl = "",
                GoogleUrl = "",
                LinkedInUrl = "",
                MsdnUrl = "",
                MvpUrl = "",
                TwitterUrl = "",
                YouTubeUrl = "",
                WebUrl = "",
                CompanyName = "ELEKS",
                JobTitle = "Senior Software Developer"
            };
        }

        public SpeakerEntity EWasilewski()
        {
            return new SpeakerEntity
            {
                Id = "EWasilewski",
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.EWasilewski.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.EWasilewski.LastName,
                Bio = AzureDay.WebApp.Localization.App.Service.Speaker.EWasilewski.Bio.Replace(Environment.NewLine, "<br/>"),
                Country = _countryService.Poland,
                PhotoUrl = "/images/avatars/EmilWasilewski2.png",
                FacebookUrl = "",
                GitHubUrl = "",
                GoogleUrl = "",
                LinkedInUrl = "http://www.linkedin.com/in/emilwasilewski",
                MsdnUrl = "",
                MvpUrl = "",
                TwitterUrl = "https://twitter.com/WasilewskiEmil",
                YouTubeUrl = "",
                WebUrl = "",
                CompanyName = "Bystronic Group",
                JobTitle = "Senior Azure Infrastructure Architect"
            };
        }

        public SpeakerEntity AVidishchev()
        {
            return new SpeakerEntity
            {
                Id = "AVidishchev",
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.AVidishchev.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.AVidishchev.LastName,
                Bio = AzureDay.WebApp.Localization.App.Service.Speaker.AVidishchev.Bio.Replace(Environment.NewLine, "<br/>"),
                Country = _countryService.Ukraine,
                PhotoUrl = "/images/avatars/AVidishchev.jpg",
                FacebookUrl = "https://www.facebook.com/anton.vidishchev",
                GitHubUrl = "",
                GoogleUrl = "",
                LinkedInUrl = "https://www.linkedin.com/in/antonvidishchev",
                MsdnUrl = "",
                MvpUrl = "",
                TwitterUrl = "",
                YouTubeUrl = "",
                WebUrl = "",
                CompanyName = "SoftServe",
                JobTitle = "Azure Architect"
            };
        }

        public SpeakerEntity VBezmaly()
        {
            return new SpeakerEntity
            {
                Id = "VBezmaly",
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.VBezmaly.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.VBezmaly.LastName,
                Bio = AzureDay.WebApp.Localization.App.Service.Speaker.VBezmaly.Bio.Replace(Environment.NewLine, "<br/>"),
                Country = _countryService.Ukraine,
                PhotoUrl = "/images/avatars/VBezmaly.jpg",
                FacebookUrl = "https://www.facebook.com/vlad.bezmaly",
                GitHubUrl = "",
                GoogleUrl = "",
                LinkedInUrl = "",
                MsdnUrl = "",
                MvpUrl = "",
                TwitterUrl = "",
                YouTubeUrl = "",
                WebUrl = "",
                CompanyName = "Kaspersky Lab",
                JobTitle = "Kaspersky Certified Trainer"
            };
        }

        public SpeakerEntity OKrakovetskyi()
        {
            return new SpeakerEntity
            {
                Id = "OKrakovetskyi",
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.OKrakovetskyi.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.OKrakovetskyi.LastName,
                Bio = AzureDay.WebApp.Localization.App.Service.Speaker.OKrakovetskyi.Bio.Replace(Environment.NewLine, "<br/>"),
                Country = _countryService.Ukraine,
                PhotoUrl = "/images/avatars/OKrakovetskyi.jpg",
                FacebookUrl = "https://www.facebook.com/alex.krakovetskiy",
                GitHubUrl = "",
                GoogleUrl = "",
                LinkedInUrl = "https://www.linkedin.com/in/krakovetskiy/",
                MsdnUrl = "",
                MvpUrl = "",
                TwitterUrl = "https://twitter.com/msugvnua",
                YouTubeUrl = "",
                WebUrl = "",
                CompanyName = "DevRain Solutions",
                JobTitle = "CEO"
            };
        }

        public SpeakerEntity SPoplavskiy()
        {
            return new SpeakerEntity
            {
                Id = "SPoplavskiy",
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.SPoplavskiy.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.SPoplavskiy.LastName,
                Bio = AzureDay.WebApp.Localization.App.Service.Speaker.SPoplavskiy.Bio.Replace(Environment.NewLine, "<br/>"),
                Country = _countryService.Ukraine,
                PhotoUrl = "/images/avatars/SPoplavskiy.png",
                FacebookUrl = "https://www.facebook.com/sergey.poplavskiy.35",
                GitHubUrl = "",
                GoogleUrl = "",
                LinkedInUrl = "",
                MsdnUrl = "",
                MvpUrl = "",
                TwitterUrl = "",
                YouTubeUrl = "",
                WebUrl = "",
                CompanyName = "Microsoft",
                JobTitle = "Microsoft Azure Software Developer"
            };
        }

        public SpeakerEntity NDranchuk()
        {
            return new SpeakerEntity
            {
                Id = "NDranchuk",
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.NDranchuk.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.NDranchuk.LastName,
                Bio = AzureDay.WebApp.Localization.App.Service.Speaker.NDranchuk.Bio.Replace(Environment.NewLine, "<br/>"),
                Country = _countryService.Ukraine,
                PhotoUrl = "/images/avatars/NDranchuk.jpg",
                FacebookUrl = "",
                GitHubUrl = "",
                GoogleUrl = "",
                LinkedInUrl = "https://www.linkedin.com/in/nataliia-dranchuk-0618b0107/",
                MsdnUrl = "",
                MvpUrl = "",
                TwitterUrl = "",
                YouTubeUrl = "",
                WebUrl = "",
                CompanyName = "Smart Business",
                JobTitle = ".NET developer"
            };
        }

        public SpeakerEntity KBaczyk()
        {
            return new SpeakerEntity
            {
                Id = "KBaczyk",
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.KBaczyk.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.KBaczyk.LastName,
                Bio = AzureDay.WebApp.Localization.App.Service.Speaker.KBaczyk.Bio.Replace(Environment.NewLine, "<br/>"),
                Country = _countryService.Poland,
                PhotoUrl = "/images/avatars/KBaczyk.jpg",
                FacebookUrl = "",
                GitHubUrl = "",
                GoogleUrl = "",
                LinkedInUrl = "https://www.linkedin.com/in/kamil-b%C4%85czyk-32093714/",
                MsdnUrl = "",
                MvpUrl = "",
                TwitterUrl = "https://twitter.com/kamilbaczyk",
                YouTubeUrl = "",
                WebUrl = "",
                CompanyName = "Microsoft",
                JobTitle = "Microsoft MVP Profile and Public Speaking info"
            };
        }

        public SpeakerEntity ILubenets()
        {
            return new SpeakerEntity
            {
                Id = "ILubenets",
                FirstName = AzureDay.WebApp.Localization.App.Service.Speaker.ILubenets.FirstName,
                LastName = AzureDay.WebApp.Localization.App.Service.Speaker.ILubenets.LastName,
                Bio = AzureDay.WebApp.Localization.App.Service.Speaker.ILubenets.Bio.Replace(Environment.NewLine, "<br/>"),
                Country = _countryService.Ukraine,
                PhotoUrl = "/images/avatars/ILubenets.jpg",
                FacebookUrl = "",
                GitHubUrl = "",
                GoogleUrl = "",
                LinkedInUrl = "https://www.linkedin.com/in/illia-lubenets-b16b15b6/",
                MsdnUrl = "",
                MvpUrl = "",
                TwitterUrl = "",
                YouTubeUrl = "",
                WebUrl = "",
                CompanyName = "Aistant",
                JobTitle = "Senior Software Engineer Team Lead"
            };
        }
    }
}