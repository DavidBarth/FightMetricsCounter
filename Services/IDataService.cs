using MMAApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMAApp.Services
{
    interface IDataService
    {
        List<Fighter> GetFighters();
    }
}
