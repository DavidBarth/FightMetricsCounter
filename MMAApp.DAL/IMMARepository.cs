using MMAApp.Model;
using System.Collections.Generic;

namespace MMAApp.DAL
{
    public interface IMMARepository
    {
        List<Fighter> GetFighters();
    }
}
