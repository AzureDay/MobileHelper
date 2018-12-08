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
                new Category { Color = "33cc33", Name = "BIG DATA STREAM", ShortName = "BIG DATA" },
                new Category { Color = "b30000", Name = "DEVOPS STREAM", ShortName = "DEVOPS" },
                new Category { Color = "80b3ff", Name = "COMMON STREAM", ShortName = "COMMON" },
            };
        }

        public Category CategoryBigData { get { return Storage.Single(x => x.Name == "BIG DATA STREAM"); } } //room1
        public Category CategoryDevOps { get { return Storage.Single(x => x.Name == "DEVOPS STREAM"); } } //room2
        public Category CategoryCommon { get { return Storage.Single(x => x.Name == "COMMON STREAM"); } } //room3
    }
}