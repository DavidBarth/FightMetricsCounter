using MMAApp.Model;
using System.Collections.Generic;

namespace MMAApp.DAL
{
    public class MMARepository : IMMARepository
    {
        private static List<Fighter> _fighers;

        public MMARepository() { }

        public List<Fighter> GetFighters()
        {
            if(_fighers == null)
            {
                LoadFighters();
            }
            return _fighers;
        }

        private void LoadFighters()
        {
           _fighers = new List<Fighter>()
           {
               new Fighter()
               {
                   Name = "Conor McGregor"
               },
                new Fighter()
                {
                    Name = "Nate Diaz"
                }
           };
        }
    }
}
