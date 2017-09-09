using MMAApp.DAL;
using MMAApp.Model;
using System.Collections.Generic;

namespace MMAApp.Services
{
    class DataService : IDataService
    {
 
        public List<Fighter> GetFighters()
        {

            IMMARepository repository = new MMARepository();
            return repository.GetFighters();
        }
    }
}
