using Conference.Backend.Services;
using Conference.DataObjects;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Conference.Backend.Models
{
    public class ConferenceContextInitializer : CreateDatabaseIfNotExists<ConferenceContext>
    {
        //private readonly Lazy<RoomService> _roomService = new Lazy<RoomService>(() => new RoomService());
        private readonly Lazy<CategoryService> _categoryService = new Lazy<CategoryService>(() => new CategoryService());
        private readonly Lazy<SponsorService> _sponsorService = new Lazy<SponsorService>(() => new SponsorService());
        private readonly Lazy<SpeakerService> _speakerService = new Lazy<SpeakerService>(() => new SpeakerService());
        private readonly Lazy<SessionService> _sessionService = new Lazy<SessionService>(() => new SessionService());

        protected override void Seed(ConferenceContext context)
        {
            context.Sponsors.AddRange(_sponsorService.Value.GetAll());
            context.Categories.AddRange(_categoryService.Value.GetAll());
            //context.Rooms.AddRange(_roomService.Value.GetAll());
            context.Speakers.AddRange(_speakerService.Value.GetAll());
            context.Sessions.AddRange(_sessionService.Value.GetAll());

            base.Seed(context);
        }
    }
}