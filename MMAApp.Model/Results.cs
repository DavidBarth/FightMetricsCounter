namespace MMAApp.Model
{
    public class Results
    {
        public int headShot { get; set; }
        public int bodyShot { get; set; }
        public int legShot { get; set; }

        public Results()
        {
            bodyShot = 0;
            headShot = 0;
            legShot = 0;
        }
    }
}