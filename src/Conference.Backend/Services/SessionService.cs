using Conference.DataObjects;
using System;
using System.Collections.Generic;

namespace Conference.Backend.Services
{
    public class SessionService : BaseService<Session>
    {
        private readonly SpeakerService _speakerService = new SpeakerService();
        private readonly CategoryService _categoryService = new CategoryService();
        //private readonly RoomService _roomService = new RoomService();

        protected override List<Session> PopulateStorage()
        {
            return new List<Session>
            {
                new Session
                {
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.Food.Registration.Title,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.Food.Registration.Title,
                    StartTime = new DateTime(2018, 12, 8, 9, 30, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 12, 8, 10, 30, 0, DateTimeKind.Utc).AddHours(5),
                },
                new Session
                {
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.Food.CoffeeBreak.Title,
                    Abstract = AzureDay.WebApp.Localization.App.Service.Topics.Food.CoffeeBreak.Description,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.Food.CoffeeBreak.Title,
                    StartTime = new DateTime(2018, 12, 8, 11, 50, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 12, 8, 12, 20, 0, DateTimeKind.Utc).AddHours(5),
                },
                new Session
                {
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.Food.Lunch.Title,
                    Abstract = AzureDay.WebApp.Localization.App.Service.Topics.Food.Lunch.Description,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.Food.Lunch.Title,
                    StartTime = new DateTime(2018, 12, 8, 13, 10, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 12, 8, 14, 0, 0, DateTimeKind.Utc).AddHours(5),
                },
                new Session
                {
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.Food.CoffeeBreak.Title,
                    Abstract = AzureDay.WebApp.Localization.App.Service.Topics.Food.CoffeeBreak.Description,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.Food.CoffeeBreak.Title,
                    StartTime = new DateTime(2018, 12, 8, 14, 50, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 12, 8, 15, 15, 0, DateTimeKind.Utc).AddHours(5),
                },
                new Session
                {
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.Food.Break.Title,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.Food.Break.Title,
                    StartTime = new DateTime(2018, 12, 8, 16, 05, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 12, 8, 16, 15, 0, DateTimeKind.Utc).AddHours(5),
                },
                new Session
                {
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.Special.Endnote.Title,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.Special.Endnote.Title,
                    StartTime = new DateTime(2018, 12, 8, 17, 05, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 12, 8, 18, 05, 0, DateTimeKind.Utc).AddHours(5),
                },
                //common stream
                new Session
                {
                    Speakers = new List<Speaker> { _speakerService.ALaysha(), _speakerService.AKozhemiakin(), _speakerService.RNovik() },
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.Special.Keynote.Title,
                    Abstract = AzureDay.WebApp.Localization.App.Service.Topics.Special.Keynote.Description,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.Special.Keynote.Title,
                    MainCategory = _categoryService.CategoryCommon,
                    StartTime = new DateTime(2018, 12, 8, 10, 30, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 12, 8, 11, 0, 0, DateTimeKind.Utc).AddHours(5),
                },
                new Session
                {
                    Speakers = new List<Speaker> { _speakerService.UKastelic() },
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.UKastelic_01.Title,
                    Abstract = AzureDay.WebApp.Localization.App.Service.Topics.UKastelic_01.Description,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.UKastelic_01.Title,
                    MainCategory = _categoryService.CategoryCommon,
                    StartTime = new DateTime(2018, 12, 8, 11, 0, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 12, 8, 11, 50, 0, DateTimeKind.Utc).AddHours(5),
                },
                //big data stream
                new Session
                {
                    Speakers = new List<Speaker> { _speakerService.RNovik() },
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.RNovik_01.Title,
                    Abstract = AzureDay.WebApp.Localization.App.Service.Topics.RNovik_01.Description,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.RNovik_01.Title,
                    MainCategory = _categoryService.CategoryBigData,
                    StartTime = new DateTime(2018, 12, 8, 12, 20, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 12, 8, 13, 10, 0, DateTimeKind.Utc).AddHours(5),
                },
                new Session
                {
                    Speakers = new List<Speaker> { _speakerService.ALaysha() },
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.ALaysha_01.Title,
                    Abstract = AzureDay.WebApp.Localization.App.Service.Topics.ALaysha_01.Description,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.ALaysha_01.Title,
                    MainCategory = _categoryService.CategoryBigData,
                    StartTime = new DateTime(2018, 12, 8, 14, 0, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 12, 8, 14, 50, 0, DateTimeKind.Utc).AddHours(5),
                },
                new Session
                {
                    Speakers = new List<Speaker> { _speakerService.RNovik(), _speakerService.LDauhiala() },
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.RNovik_LDauhiala_01.Title,
                    Abstract = AzureDay.WebApp.Localization.App.Service.Topics.RNovik_LDauhiala_01.Description,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.RNovik_LDauhiala_01.Title,
                    MainCategory = _categoryService.CategoryBigData,
                    StartTime = new DateTime(2018, 12, 8, 15, 15, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 12, 8, 16, 05, 0, DateTimeKind.Utc).AddHours(5),
                },
                new Session
                {
                    Speakers = new List<Speaker> { _speakerService.KSultanov() },
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.KSultanov_01.Title,
                    Abstract = AzureDay.WebApp.Localization.App.Service.Topics.KSultanov_01.Description,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.KSultanov_01.Title,
                    MainCategory = _categoryService.CategoryBigData,
                    StartTime = new DateTime(2018, 12, 8, 16, 15, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 12, 8, 17, 05, 0, DateTimeKind.Utc).AddHours(5),
                },
                //devops stream
                new Session
                {
                    Speakers = new List<Speaker> { _speakerService.ABoyko() },
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.ABoyko_01.Title,
                    Abstract = AzureDay.WebApp.Localization.App.Service.Topics.ABoyko_01.Description,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.ABoyko_01.Title,
                    MainCategory = _categoryService.CategoryDevOps,
                    StartTime = new DateTime(2018, 12, 8, 12, 20, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 12, 8, 13, 10, 0, DateTimeKind.Utc).AddHours(5),
                },
                new Session
                {
                    Speakers = new List<Speaker> { _speakerService.ARamanchyk() },
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.ARamanchyk_01.Title,
                    Abstract = AzureDay.WebApp.Localization.App.Service.Topics.ARamanchyk_01.Description,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.ARamanchyk_01.Title,
                    MainCategory = _categoryService.CategoryDevOps,
                    StartTime = new DateTime(2018, 12, 8, 14, 0, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 12, 8, 14, 50, 0, DateTimeKind.Utc).AddHours(5),
                },
                new Session
                {
                    Speakers = new List<Speaker> { _speakerService.EBogdanov(), _speakerService.AIvlev() },
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.EBogdanov_AIvlev_01.Title,
                    Abstract = AzureDay.WebApp.Localization.App.Service.Topics.EBogdanov_AIvlev_01.Description,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.EBogdanov_AIvlev_01.Title,
                    MainCategory = _categoryService.CategoryDevOps,
                    StartTime = new DateTime(2018, 12, 8, 15, 15, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 12, 8, 16, 05, 0, DateTimeKind.Utc).AddHours(5),
                },
                new Session
                {
                    Speakers = new List<Speaker> { _speakerService.DLappo() },
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.DLappo_01.Title,
                    Abstract = AzureDay.WebApp.Localization.App.Service.Topics.DLappo_01.Description,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.DLappo_01.Title,
                    MainCategory = _categoryService.CategoryDevOps,
                    StartTime = new DateTime(2018, 12, 8, 16, 15, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 12, 8, 17, 05, 0, DateTimeKind.Utc).AddHours(5),
                },
                #region Ukraine
                /*new Session
                {
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.Food.Registration.Title,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.Food.Registration.Title,
                    StartTime = new DateTime(2018, 11, 10, 8, 15, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 11, 10, 9, 0, 0, DateTimeKind.Utc).AddHours(5),
                },
                new Session
                {
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.Food.Break.Title,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.Food.Break.Title,
                    StartTime = new DateTime(2018, 11, 10, 10, 0, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 11, 10, 10, 15, 0, DateTimeKind.Utc).AddHours(5),
                },
                new Session
                {
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.Food.CoffeeBreak.Title,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.Food.CoffeeBreak.Title,
                    StartTime = new DateTime(2018, 11, 10, 11, 15, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 11, 10, 11, 45, 0, DateTimeKind.Utc).AddHours(5),
                },
                new Session
                {
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.Food.Break.Title,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.Food.Break.Title,
                    StartTime = new DateTime(2018, 11, 10, 12, 45, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 11, 10, 13, 00, 0, DateTimeKind.Utc).AddHours(5),
                },
                new Session
                {
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.Food.Lunch.Title,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.Food.Lunch.Title,
                    StartTime = new DateTime(2018, 11, 10, 14, 00, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 11, 10, 14, 45, 0, DateTimeKind.Utc).AddHours(5),
                },
                new Session
                {
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.Food.Break.Title,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.Food.Break.Title,
                    StartTime = new DateTime(2018, 11, 10, 15, 45, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 11, 10, 16, 0, 0, DateTimeKind.Utc).AddHours(5),
                },
                new Session
                {
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.Food.CoffeeBreak.Title,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.Food.CoffeeBreak.Title,
                    StartTime = new DateTime(2018, 11, 10, 17, 0, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 11, 10, 17, 30, 0, DateTimeKind.Utc).AddHours(5),
                },
                //orange room
                new Session
                {
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.Special.Keynote.Title,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.Special.Keynote.Title,
                    MainCategory = _categoryService.CategoryOrange,
                    //Room = _roomService.Room1,
                    StartTime = new DateTime(2018, 11, 10, 9, 0, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 11, 10, 10, 0, 0, DateTimeKind.Utc).AddHours(5),
                },
                new Session
                {
                    Speakers = new List<Speaker> { _speakerService.SPoplavskiy() },
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.SPoplavskiy_01.Title,
                    Abstract = AzureDay.WebApp.Localization.App.Service.Topics.SPoplavskiy_01.Description,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.SPoplavskiy_01.Title,
                    MainCategory = _categoryService.CategoryOrange,
                    //Room = _roomService.Room3,
                    StartTime = new DateTime(2018, 11, 10, 10, 15, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 11, 10, 11, 15, 0, DateTimeKind.Utc).AddHours(5),
                },
                new Session
                {
                    Speakers = new List<Speaker> { _speakerService.ASurkov() },
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.ASurkov_01.Title,
                    Abstract = AzureDay.WebApp.Localization.App.Service.Topics.ASurkov_01.Description,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.ASurkov_01.Title,
                    MainCategory = _categoryService.CategoryOrange,
                    //Room = _roomService.Room1,
                    StartTime = new DateTime(2018, 11, 10, 11, 45, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 11, 10, 12, 45, 0, DateTimeKind.Utc).AddHours(5),
                },
                new Session
                {
                    Speakers = new List<Speaker> { _speakerService.EWasilewski() },
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.EWasilewski_01.Title,
                    Abstract = AzureDay.WebApp.Localization.App.Service.Topics.EWasilewski_01.Description,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.EWasilewski_01.Title,
                    MainCategory = _categoryService.CategoryOrange,
                    //Room = _roomService.Room1,
                    StartTime = new DateTime(2018, 11, 10, 13, 0, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 11, 10, 14, 0, 0, DateTimeKind.Utc).AddHours(5),
                },
                new Session
                {
                    Speakers = new List<Speaker> { _speakerService.KBaczyk() },
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.KBaczyk_01.Title,
                    Abstract = AzureDay.WebApp.Localization.App.Service.Topics.KBaczyk_01.Description,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.KBaczyk_01.Title,
                    MainCategory = _categoryService.CategoryOrange,
                    //Room = _roomService.Room2,
                    StartTime = new DateTime(2018, 11, 10, 14, 45, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 11, 10, 15, 45, 0, DateTimeKind.Utc).AddHours(5),
                },
                new Session
                {
                    Speakers = new List<Speaker> { _speakerService.AVidishchev() },
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.AVidishchev_01.Title,
                    Abstract = AzureDay.WebApp.Localization.App.Service.Topics.AVidishchev_01.Description,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.AVidishchev_01.Title,
                    MainCategory = _categoryService.CategoryOrange,
                    //Room = _roomService.Room2,
                    StartTime = new DateTime(2018, 11, 10, 16, 0, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 11, 10, 17, 0, 0, DateTimeKind.Utc).AddHours(5),
                },
                new Session
                {
                    Speakers = new List<Speaker> { _speakerService.ABoyko() },
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.ABoyko_01.Title,
                    Abstract = AzureDay.WebApp.Localization.App.Service.Topics.ABoyko_01.Description,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.ABoyko_01.Title,
                    MainCategory = _categoryService.CategoryOrange,
                    //Room = _roomService.Room1,
                    StartTime = new DateTime(2018, 11, 10, 17, 30, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 11, 10, 18, 30, 0, DateTimeKind.Utc).AddHours(5),
                },
                new Session
                {
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.Special.Endnote.Title,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.Special.Endnote.Title,
                    MainCategory = _categoryService.CategoryOrange,
                    //Room = _roomService.Room1,
                    StartTime = new DateTime(2018, 11, 10, 18, 30, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 11, 10, 19, 15, 0, DateTimeKind.Utc).AddHours(5),
                },
                //blue room
                new Session
                {
                    Speakers = new List<Speaker> { _speakerService.SLebedenko() },
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.SLebedenko_01.Title,
                    Abstract = AzureDay.WebApp.Localization.App.Service.Topics.SLebedenko_01.Description,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.SLebedenko_01.Title,
                    MainCategory = _categoryService.CategoryBlue,
                    //Room = _roomService.Room3,
                    StartTime = new DateTime(2018, 11, 10, 10, 15, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 11, 10, 11, 15, 0, DateTimeKind.Utc).AddHours(5),
                },
                new Session
                {
                    Speakers = new List<Speaker> { _speakerService.SBielskyi() },
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.SBielskyi_01.Title,
                    Abstract = AzureDay.WebApp.Localization.App.Service.Topics.SBielskyi_01.Description,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.SBielskyi_01.Title,
                    MainCategory = _categoryService.CategoryBlue,
                    //Room = _roomService.Room2,
                    StartTime = new DateTime(2018, 11, 10, 11, 45, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 11, 10, 12, 45, 0, DateTimeKind.Utc).AddHours(5),
                },
                new Session
                {
                    Speakers = new List<Speaker> { _speakerService.ILeontiev() },
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.ILeontiev_01.Title,
                    Abstract = AzureDay.WebApp.Localization.App.Service.Topics.ILeontiev_01.Description,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.ILeontiev_01.Title,
                    MainCategory = _categoryService.CategoryBlue,
                    //Room = _roomService.Room2,
                    StartTime = new DateTime(2018, 11, 10, 13, 0, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 11, 10, 14, 0, 0, DateTimeKind.Utc).AddHours(5),
                },
                new Session
                {
                    Speakers = new List<Speaker> { _speakerService.SSultanov() },
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.SSultanov_01.Title,
                    Abstract = AzureDay.WebApp.Localization.App.Service.Topics.SSultanov_01.Description,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.SSultanov_01.Title,
                    MainCategory = _categoryService.CategoryBlue,
                    //Room = _roomService.Room1,
                    StartTime = new DateTime(2018, 11, 10, 14, 45, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 11, 10, 15, 45, 0, DateTimeKind.Utc).AddHours(5),
                },
                new Session
                {
                    Speakers = new List<Speaker> { _speakerService.EAuberix() },
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.EAuberix_01.Title,
                    Abstract = AzureDay.WebApp.Localization.App.Service.Topics.EAuberix_01.Description,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.EAuberix_01.Title,
                    MainCategory = _categoryService.CategoryBlue,
                    //Room = _roomService.Room2,
                    StartTime = new DateTime(2018, 11, 10, 16, 0, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 11, 10, 17, 0, 0, DateTimeKind.Utc).AddHours(5),
                },
                new Session
                {
                    Speakers = new List<Speaker> { _speakerService.SPoplavskiy() },
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.SPoplavskiy_02.Title,
                    Abstract = AzureDay.WebApp.Localization.App.Service.Topics.SPoplavskiy_02.Description,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.SPoplavskiy_02.Title,
                    MainCategory = _categoryService.CategoryBlue,
                    //Room = _roomService.Room3,
                    StartTime = new DateTime(2018, 11, 10, 17, 30, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 11, 10, 18, 30, 0, DateTimeKind.Utc).AddHours(5),
                },
                //red room
                new Session
                {
                    Speakers = new List<Speaker> { _speakerService.VTsykunov() },
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.VTsykunov_01.Title,
                    Abstract = AzureDay.WebApp.Localization.App.Service.Topics.VTsykunov_01.Description,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.VTsykunov_01.Title,
                    MainCategory = _categoryService.CategoryRed,
                    //Room = _roomService.Room3,
                    StartTime = new DateTime(2018, 11, 10, 10, 15, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 11, 10, 11, 15, 0, DateTimeKind.Utc).AddHours(5),
                },
                new Session
                {
                    Speakers = new List<Speaker> { _speakerService.NDranchuk() },
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.NDranchuk_01.Title,
                    Abstract = AzureDay.WebApp.Localization.App.Service.Topics.NDranchuk_01.Description,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.NDranchuk_01.Title,
                    MainCategory = _categoryService.CategoryRed,
                    //Room = _roomService.Room2,
                    StartTime = new DateTime(2018, 11, 10, 11, 45, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 11, 10, 12, 45, 0, DateTimeKind.Utc).AddHours(5),
                },
                new Session
                {
                    Speakers = new List<Speaker> { _speakerService.OKrakovetskyi() },
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.OKrakovetskyi_02.Title,
                    Abstract = AzureDay.WebApp.Localization.App.Service.Topics.OKrakovetskyi_02.Description,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.OKrakovetskyi_02.Title,
                    MainCategory = _categoryService.CategoryRed,
                    //Room = _roomService.Room3,
                    StartTime = new DateTime(2018, 11, 10, 13, 0, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 11, 10, 14, 0, 0, DateTimeKind.Utc).AddHours(5),
                },
                new Session
                {
                    Speakers = new List<Speaker> { _speakerService.EPolonychko() },
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.EPolonychko_01.Title,
                    Abstract = AzureDay.WebApp.Localization.App.Service.Topics.EPolonychko_01.Description,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.EPolonychko_01.Title,
                    MainCategory = _categoryService.CategoryRed,
                    //Room = _roomService.Room3,
                    StartTime = new DateTime(2018, 11, 10, 14, 45, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 11, 10, 15, 45, 0, DateTimeKind.Utc).AddHours(5),
                },         
                new Session
                {
                    Speakers = new List<Speaker> { _speakerService.ILubenets() },
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.ILubenets_01.Title,
                    Abstract = AzureDay.WebApp.Localization.App.Service.Topics.ILubenets_01.Description,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.ILubenets_01.Title,
                    MainCategory = _categoryService.CategoryRed,
                    //Room = _roomService.Room1,
                    StartTime = new DateTime(2018, 11, 10, 16, 0, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 11, 10, 17, 0, 0, DateTimeKind.Utc).AddHours(5),
                },
                new Session
                {
                    Speakers = new List<Speaker> { _speakerService.NMykhailenko() },
                    Title = AzureDay.WebApp.Localization.App.Service.Topics.NMykhailenko_01.Title,
                    Abstract = AzureDay.WebApp.Localization.App.Service.Topics.NMykhailenko_01.Description,
                    ShortTitle = AzureDay.WebApp.Localization.App.Service.Topics.NMykhailenko_01.Title,
                    MainCategory = _categoryService.CategoryRed,
                    //Room = _roomService.Room1,
                    StartTime = new DateTime(2018, 11, 10, 17, 30, 0, DateTimeKind.Utc).AddHours(5),
                    EndTime = new DateTime(2018, 11, 10, 18, 30, 0, DateTimeKind.Utc).AddHours(5),
                }, */
                #endregion Ukraine
            };
        }
    }
}