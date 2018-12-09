using Conference.DataObjects;
using System.Collections.Generic;
using System.Linq;

namespace Conference.Backend.Services
{
    public class CategoryService : BaseService<Category>
    {
        protected override List<Category> PopulateStorage()
        {
            return new List<Category>
            {
                new Category { Color = "ff9800", Name = "Технологический трек", ShortName = "Техно" },
                new Category { Color = "2196f3", Name = "Бизнес трек", ShortName = "Бизнес" }
            };
        }

        public Category CategoryTechno { get { return Storage.Single(x => x.Name == "Технологический трек"); } } //room1
        public Category CategoryBusiness { get { return Storage.Single(x => x.Name == "Бизнес трек"); } } //room2
    }
}