using System.Collections.Generic;

namespace Conference.Backend.Services
{
    public abstract class BaseService<T>
    {
        private List<T> _storage;
        protected List<T> Storage => _storage ?? (_storage = PopulateStorage());

        protected abstract List<T> PopulateStorage();

        public IEnumerable<T> GetAll()
        {
            return Storage;
        }
    }
}