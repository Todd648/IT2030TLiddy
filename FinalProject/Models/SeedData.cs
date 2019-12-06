using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FinalProject.Models
{
    public class SeedData : DropCreateDatabaseAlways<MVCEventDB>
    {
        protected override void Seed(MVCEventDB context)
        {
            var eventTypes = new List<EventType>
            {
                new EventType { Name = "Convention" },
                new EventType { Name = "Theatre" },
                new EventType { Name = "Movie" },
                new EventType { Name = "Dining" },
                new EventType { Name = "Concert" },
                new EventType { Name = "Festival" },
                new EventType { Name = "Gathering" },
                new EventType { Name = "Shenanigans" },

            };

            //new List<EventType>
            //{
            //    new EventType { Name = "Convention" },
            //    new EventType { Name = "Theatre" },
            //    new EventType { Name = "Movie" },
            //    new EventType { Name = "Dining" },
            //    new EventType { Name = "Concert" },
            //    new EventType { Name = "Festival" },
            //    new EventType { Name = "Gathering" },
            //    new EventType { Name = "Shenanigans" },
            //}.ForEach(a => context.EventTypes.Add(a));

            new List<Event>
            {
                 new Event { EventID = 1, MaxTickets = 4705, AvailableTickets = 962,  Type = eventTypes.Single(g => g.Name == "Convention"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime( "12/12/19 09:01"), EndDate = Convert.ToDateTime("12/12/19 21:29") },
                 new Event { EventID = 2, MaxTickets = 6131, AvailableTickets = 862, Type = eventTypes.Single(g => g.Name == "Theatre"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("11/29/19 18:21"), EndDate = Convert.ToDateTime("11/30/19 15:46") },
                 new Event { EventID = 3, MaxTickets = 890, AvailableTickets = 142, Type = eventTypes.Single(g => g.Name == "Movie"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("11/27/19 22:25"), EndDate = Convert.ToDateTime("11/28/19 00:23") },
                 new Event { EventID = 4, MaxTickets = 8613, AvailableTickets = 7530, Type = eventTypes.Single(g => g.Name == "Convention"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("11/11/19 14:06"), EndDate = Convert.ToDateTime("11/11/19 20:48") },
                 new Event { EventID = 5, MaxTickets = 9165, AvailableTickets = 8899, Type = eventTypes.Single(g => g.Name == "Concert"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("12/26/19 19:13"), EndDate = Convert.ToDateTime("12/27/19 06:56") },
                 new Event { EventID = 6, MaxTickets = 8071, AvailableTickets = 3154, Type = eventTypes.Single(g => g.Name == "Movie"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("11/12/19 15:07"), EndDate = Convert.ToDateTime("11/12/19 23:17") },
                 new Event { EventID = 7, MaxTickets = 3690, AvailableTickets = 2505, Type = eventTypes.Single(g => g.Name == "Movie"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("12/15/19 23:37"), EndDate = Convert.ToDateTime("12/15/19 23:56") },
                 new Event { EventID = 8, MaxTickets = 660, AvailableTickets = 453, Type = eventTypes.Single(g => g.Name == "Festival"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("12/10/19 06:58"), EndDate = Convert.ToDateTime("12/10/19 14:20") },
                 new Event { EventID = 9, MaxTickets = 9519, AvailableTickets = 15, Type = eventTypes.Single(g => g.Name == "Movie"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("11/03/19 19:45"), EndDate = Convert.ToDateTime("11/04/19 14:34") },
                 new Event { EventID = 10, MaxTickets = 383, AvailableTickets = 293, Type = eventTypes.Single(g => g.Name == "Dining"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("11/03/19 10:16"), EndDate = Convert.ToDateTime("11/04/19 00:42") },
                 new Event { EventID = 11, MaxTickets = 6491, AvailableTickets = 5584, Type = eventTypes.Single(g => g.Name == "Movie"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("11/10/19 19:20"), EndDate = Convert.ToDateTime("11/10/19 19:48") },
                 new Event { EventID = 12, MaxTickets = 9540, AvailableTickets = 8423, Type = eventTypes.Single(g => g.Name == "Shenanigans"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("10/29/19 08:08"), EndDate = Convert.ToDateTime("10/29/19 16:04") },
                 new Event { EventID = 13, MaxTickets = 2519, AvailableTickets = 67, Type = eventTypes.Single(g => g.Name == "Festival"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("11/24/19 01:54"), EndDate = Convert.ToDateTime("11/24/19 04:32") },
                 new Event { EventID = 14, MaxTickets = 1972, AvailableTickets = 1221, Type = eventTypes.Single(g => g.Name == "Dining"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("12/04/19 23:25"), EndDate = Convert.ToDateTime("12/05/19 16:49") },
                 new Event { EventID = 15, MaxTickets = 4691, AvailableTickets = 1251, Type = eventTypes.Single(g => g.Name == "Theatre"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("11/30/19 11:22"), EndDate = Convert.ToDateTime("11/30/19 13:34") },
                 new Event { EventID = 16, MaxTickets = 364, AvailableTickets = 143, Type = eventTypes.Single(g => g.Name == "Convention"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("11/30/19 08:37"), EndDate = Convert.ToDateTime("11/30/19 11:24") },
                 new Event { EventID = 17, MaxTickets = 3828, AvailableTickets = 1979, Type = eventTypes.Single(g => g.Name == "Convention"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("12/06/19 07:36"), EndDate = Convert.ToDateTime("12/07/19 03:26") },
                 new Event { EventID = 18, MaxTickets = 2079, AvailableTickets = 802, Type = eventTypes.Single(g => g.Name == "Festival"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("11/05/19 00:23"), EndDate = Convert.ToDateTime("11/05/19 17:30") },
                 new Event { EventID = 19, MaxTickets = 8031, AvailableTickets = 5350, Type = eventTypes.Single(g => g.Name == "Dining"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("12/19/19 04:24"), EndDate = Convert.ToDateTime("12/19/19 19:31") },
                 new Event { EventID = 20, MaxTickets = 1115, AvailableTickets = 906, Type = eventTypes.Single(g => g.Name == "Convention"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("12/15/19 13:29"), EndDate = Convert.ToDateTime("12/15/19 20:56") },
                 new Event { EventID = 21, MaxTickets = 888, AvailableTickets = 858, Type = eventTypes.Single(g => g.Name == "Dining"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("11/25/19 11:14"), EndDate = Convert.ToDateTime("11/26/19 07:05") },
                 new Event { EventID = 22, MaxTickets = 9993, AvailableTickets = 136, Type = eventTypes.Single(g => g.Name == "Shenanigans"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("12/22/19 20:28"), EndDate = Convert.ToDateTime("12/23/19 05:20") },
                 new Event { EventID = 23, MaxTickets = 1853, AvailableTickets = 769, Type = eventTypes.Single(g => g.Name == "Dining"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("11/04/19 03:10"), EndDate = Convert.ToDateTime("11/04/19 03:43") },
                 new Event { EventID = 24, MaxTickets = 7580, AvailableTickets = 5418, Type = eventTypes.Single(g => g.Name == "Movie"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("12/13/19 15:37"), EndDate = Convert.ToDateTime("12/14/19 12:02") },
                 new Event { EventID = 25, MaxTickets = 9379, AvailableTickets = 5902, Type = eventTypes.Single(g => g.Name == "Dining"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("12/13/19 01:35"), EndDate = Convert.ToDateTime("12/13/19 12:52") },
                 new Event { EventID = 26, MaxTickets = 9503, AvailableTickets = 8671, Type = eventTypes.Single(g => g.Name == "Convention"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("11/11/19 11:01"), EndDate = Convert.ToDateTime("11/12/19 01:11") },
                 new Event { EventID = 27, MaxTickets = 3344, AvailableTickets = 1884, Type = eventTypes.Single(g => g.Name == "Theatre"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("10/28/19 08:11"), EndDate = Convert.ToDateTime("10/28/19 20:02") },
                 new Event { EventID = 28, MaxTickets = 7704, AvailableTickets = 4773, Type = eventTypes.Single(g => g.Name == "Convention"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("12/15/19 05:12"), EndDate = Convert.ToDateTime("12/15/19 08:41") },
                 new Event { EventID = 29, MaxTickets = 9525, AvailableTickets = 1005, Type = eventTypes.Single(g => g.Name == "Shenanigans"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("11/04/19 22:36"), EndDate = Convert.ToDateTime("11/05/19 02:09") },
                 new Event { EventID = 30, MaxTickets = 1245, AvailableTickets = 115, Type = eventTypes.Single(g => g.Name == "Convention"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("12/19/19 00:23"), EndDate = Convert.ToDateTime("12/19/19 21:03") },
                 new Event { EventID = 31, MaxTickets = 9855, AvailableTickets = 833, Type = eventTypes.Single(g => g.Name == "Theatre"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("12/27/19 04:20"), EndDate = Convert.ToDateTime("12/27/19 14:59") },
                 new Event { EventID = 32, MaxTickets = 2464, AvailableTickets = 967, Type = eventTypes.Single(g => g.Name == "Theatre"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("12/24/19 11:45"), EndDate = Convert.ToDateTime("12/24/19 22:29") },
                 new Event { EventID = 33, MaxTickets = 8096, AvailableTickets = 903, Type = eventTypes.Single(g => g.Name == "Convention"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("12/20/19 16:02"), EndDate = Convert.ToDateTime("12/21/19 15:47") },
                 new Event { EventID = 34, MaxTickets = 5395, AvailableTickets = 3325, Type = eventTypes.Single(g => g.Name == "Movie"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("12/20/19 04:08"), EndDate = Convert.ToDateTime("12/20/19 23:32") },
                 new Event { EventID = 35, MaxTickets = 8254, AvailableTickets = 5750, Type = eventTypes.Single(g => g.Name == "Festival"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("11/06/19 09:27"), EndDate = Convert.ToDateTime("11/06/19 21:00") },
                 new Event { EventID = 36, MaxTickets = 7672, AvailableTickets = 2171, Type = eventTypes.Single(g => g.Name == "Theatre"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("11/30/19 08:08"), EndDate = Convert.ToDateTime("11/30/19 22:05") },
                 new Event { EventID = 37, MaxTickets = 6062, AvailableTickets = 5275, Type = eventTypes.Single(g => g.Name == "Theatre"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("11/01/19 21:09"), EndDate = Convert.ToDateTime("11/02/19 17:45") },
                 new Event { EventID = 38, MaxTickets = 9197, AvailableTickets = 5357, Type = eventTypes.Single(g => g.Name == "Shenanigans"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("11/02/19 23:30"), EndDate = Convert.ToDateTime("11/03/19 06:39") },
                 new Event { EventID = 39, MaxTickets = 3942, AvailableTickets = 1265, Type = eventTypes.Single(g => g.Name == "Shenanigans"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("11/17/19 01:50"), EndDate = Convert.ToDateTime("11/17/19 09:41") },
                 new Event { EventID = 40, MaxTickets = 7118, AvailableTickets = 4074, Type = eventTypes.Single(g => g.Name == "Movie"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("10/30/19 18:30"), EndDate = Convert.ToDateTime("10/30/19 21:08") },
                 new Event { EventID = 41, MaxTickets = 5139, AvailableTickets = 1738, Type = eventTypes.Single(g => g.Name == "Convention"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("12/24/19 09:16"), EndDate = Convert.ToDateTime("12/24/19 19:31") },
                 new Event { EventID = 42, MaxTickets = 8365, AvailableTickets = 3440, Type = eventTypes.Single(g => g.Name == "Convention"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("12/20/19 09:48"), EndDate = Convert.ToDateTime("12/20/19 20:45") },
                 new Event { EventID = 43, MaxTickets = 9579, AvailableTickets = 7116, Type = eventTypes.Single(g => g.Name == "Dining"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("12/17/19 06:28"), EndDate = Convert.ToDateTime("12/17/19 15:24") },
                 new Event { EventID = 44, MaxTickets = 498, AvailableTickets = 79, Type = eventTypes.Single(g => g.Name == "Shenanigans"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("12/15/19 07:38"), EndDate = Convert.ToDateTime("12/15/19 13:19") },
                 new Event { EventID = 45, MaxTickets = 8300, AvailableTickets = 7907, Type = eventTypes.Single(g => g.Name == "Theatre"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("12/08/19 16:35"), EndDate = Convert.ToDateTime("12/09/19 16:01") },
                 new Event { EventID = 46, MaxTickets = 4405, AvailableTickets = 1683, Type = eventTypes.Single(g => g.Name == "Concert"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("11/06/19 22:09"), EndDate = Convert.ToDateTime("11/07/19 11:18") },
                 new Event { EventID = 47, MaxTickets = 3171, AvailableTickets = 519, Type = eventTypes.Single(g => g.Name == "Theatre"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("12/02/19 17:32"), EndDate = Convert.ToDateTime("12/02/19 23:54") },
                 new Event { EventID = 48, MaxTickets = 8111, AvailableTickets = 7343, Type = eventTypes.Single(g => g.Name == "Shenanigans"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("11/29/19 14:37"), EndDate = Convert.ToDateTime("11/30/19 05:12") },
                 new Event { EventID = 49, MaxTickets = 5643, AvailableTickets = 3456, Type = eventTypes.Single(g => g.Name == "Gathering"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("12/09/19 04:07"), EndDate = Convert.ToDateTime("12/09/19 11:45") },
                 new Event { EventID = 50, MaxTickets = 3357, AvailableTickets = 236, Type = eventTypes.Single(g => g.Name == "Shenanigans"), EventName = "Something", Description = "Type something here", StartDate = Convert.ToDateTime("12/19/19 17:16"), EndDate = Convert.ToDateTime("12/20/19 03:25") }
            }.ForEach(a => context.Events.Add(a));
        }
    }
}