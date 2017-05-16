using System.Collections.Generic;

namespace MMAApp.Model
{
    /// <summary>
    /// Describes a figther that fights in an event
    /// </summary>
    public class Fighter
    {
        public string Name { get; set; }
        public List<Results> Results { get; set; }

        public Fighter()
        {
            Results = new List<Results>();
        }
    }
}
