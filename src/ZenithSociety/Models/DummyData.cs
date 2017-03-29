using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithSociety.Data;

namespace ZenithSociety.Models
{
    public class DummyData
    {
        public static void Initialize(ApplicationDbContext db)
        {

            if (!db.Activities.Any())
            {
                db.Activities.Add(new Activity()
                {
                    description = "Seniors Golf Tournament",
                    createActivity = new DateTime(2016, 12, 6)
                });
                db.Activities.Add(new Activity()
                {
                    description = "Leadership General Assembly Meeting",
                    createActivity = new DateTime(2016, 12, 3)
                });
                db.Activities.Add(new Activity()
                {
                    description = "Youth Bowling Tournament",
                    createActivity = new DateTime(2016, 11, 20)
                });
                db.Activities.Add(new Activity()
                {
                    description = "Young ladies cooking lessons",
                    createActivity = new DateTime(2016, 10, 4)
                });
                db.Activities.Add(new Activity()
                {
                    description = "Pancake Breakfast",
                    createActivity = new DateTime(2016, 10, 17)
                });
                db.Activities.Add(new Activity
                {
                    description = "Swimming Exercise for parents",
                    createActivity = new DateTime(2016, 11, 25)
                });
                db.SaveChanges();
            }

            if (!db.Events.Any())
            {
                db.Events.Add(new Event()
                {
                    eventFrom = new DateTime(2017, 2, 1, 15, 30, 00),
                    eventTo = new DateTime(2017, 2, 1, 16, 30, 00),
                    createEvent = new DateTime(2017, 1, 18),
                    Username = "a",
                    isActive = true,
                    Activity = db.Activities.Where(a => a.activityId == 3).FirstOrDefault()
                });
                db.Events.Add(new Event()
                {
                    eventFrom = new DateTime(2017, 2, 4, 12, 30, 00),
                    eventTo = new DateTime(2017, 2, 4, 13, 30, 00),
                    createEvent = new DateTime(2017, 1, 12),
                    Username = "a",
                    isActive = true,
                    Activity = db.Activities.Where(a => a.activityId == 2).FirstOrDefault()
                });
                db.Events.Add(new Event()
                {
                    eventFrom = new DateTime(2017, 2, 5, 11, 30, 00),
                    eventTo = new DateTime(2017, 2, 5, 14, 30, 00),
                    createEvent = new DateTime(2017, 1, 30),
                    Username = "a",
                    isActive = false,
                    Activity = db.Activities.Where(a => a.activityId == 1).FirstOrDefault()
                });
                db.Events.Add(new Event()
                {
                    eventFrom = new DateTime(2017, 2, 5, 18, 30, 00),
                    eventTo = new DateTime(2017, 2, 5, 20, 30, 00),
                    createEvent = new DateTime(2017, 1, 14),
                    Username = "a",
                    isActive = false,
                    Activity = db.Activities.Where(a => a.activityId == 4).FirstOrDefault()
                });
                db.Events.Add(new Event()
                {
                    eventFrom = new DateTime(2017, 2, 6, 15, 30, 00),
                    eventTo = new DateTime(2017, 2, 6, 16, 30, 00),
                    createEvent = new DateTime(2017, 1, 18),
                    Username = "a",
                    isActive = true,
                    Activity = db.Activities.Where(a => a.activityId == 5).FirstOrDefault()
                });
                db.Events.Add(new Event()
                {
                    eventFrom = new DateTime(2017, 2, 7, 15, 30, 00),
                    eventTo = new DateTime(2017, 2, 7, 16, 30, 00),
                    createEvent = new DateTime(2016, 12, 17),
                    Username = "a",
                    isActive = false,
                    Activity = db.Activities.Where(a => a.activityId == 6).FirstOrDefault()
                });
                db.Events.Add(new Event()
                {
                    eventFrom = new DateTime(2017, 2, 8, 15, 30, 00),
                    eventTo = new DateTime(2017, 2, 8, 16, 30, 00),
                    createEvent = new DateTime(2017, 1, 10),
                    Username = "a",
                    isActive = true,
                    Activity = db.Activities.Where(a => a.activityId == 4).FirstOrDefault()
                });
                db.Events.Add(new Event()
                {
                    eventFrom = new DateTime(2017, 2, 10, 10, 30, 00),
                    eventTo = new DateTime(2017, 2, 10, 14, 30, 00),
                    createEvent = new DateTime(2017, 1, 6),
                    Username = "a",
                    isActive = false,
                    Activity = db.Activities.Where(a => a.activityId == 5).FirstOrDefault()
                });
                db.Events.Add(new Event()
                {
                    eventFrom = new DateTime(2017, 2, 12, 10, 30, 00),
                    eventTo = new DateTime(2017, 2, 12, 14, 30, 00),
                    createEvent = new DateTime(2017, 1, 6),
                    Username = "a",
                    isActive = false,
                    Activity = db.Activities.Where(a => a.activityId == 6).FirstOrDefault()
                });
                db.Events.Add(new Event()
                {
                    eventFrom = new DateTime(2017, 2, 14, 10, 30, 00),
                    eventTo = new DateTime(2017, 2, 14, 14, 30, 00),
                    createEvent = new DateTime(2017, 1, 6),
                    Username = "a",
                    isActive = false,
                    Activity = db.Activities.Where(a => a.activityId == 2).FirstOrDefault()
                });
                db.SaveChanges();
            }

            

        }

        
    }
}
