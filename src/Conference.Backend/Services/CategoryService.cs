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
                new Category { Color = "ff9800", Name = "Orange Room", ShortName = "Orange" },
                new Category { Color = "2196f3", Name = "Blue Room", ShortName = "Blue" },
                new Category { Color = "f44336", Name = "Red Room", ShortName = "Red" },
            };
        }

        private Category CategoryOrange { get { return Storage.Single(x => x.Name == "Orange Room"); } }
        private Category CategoryBlue { get { return Storage.Single(x => x.Name == "Blue Room"); } }
        private Category CategoryRed { get { return Storage.Single(x => x.Name == "Red Room"); } }
    }
}