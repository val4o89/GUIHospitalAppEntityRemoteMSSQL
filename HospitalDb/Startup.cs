using System;

namespace HospitalDb
{
    public class Startup
    {
        public static void Main()
        {
            var context = new HPContext();
            context.Database.Initialize(true);
        }
    }
}
