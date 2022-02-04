//using DiChoThue.Entity;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace DiChoThue
//{
//    public static class DbInitializer
//    {
//        public static void Initialize(ModelContext context)
//        {
//            context.Database.EnsureCreated();

//            // Look for any students.
//            if (context.Shipper.Any())
//            {
//                return;   // DB has been seeded
//            }

//            var shipper = new Shipper();
//            { }
           

//            foreach (Shipper sp in shipper)
//            {
//                context.Dept.Add(d);
//            }
//            context.SaveChanges();
//        }
//    }
//}
