using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FinalEventApplication.Models
{
	public class SampleData : DropCreateDatabaseIfModelChanges<FinalEventApplicationDB>
    {
        protected override void Seed(FinalEventApplicationDB context)
        {
            var Venues = new List<Venue>
            {
                new Venue { VenueId = 1, Name = "Grogg Shoppe", City = "Cleveland" },
            };

            var Organizers = new List<Organizer>
            {
                new Organizer { OrganizerId = 1, FirstName = "Todd", LastName = "Liddy", EmailAddress = "toddj.liddy@gmail.com" , PhoneNumber ="4403051916" },
            };

            new List<Event>
            {
                new Event { EventId= 1, MaxTickets = 100, AvailTickets = 100, EventType = "Music" , Description  = "A Copland Celebration, Vol. I", StartDate = ("12/10/2020"), EndDate = "12/10/2020",  Venue = Venues.Single(g => g.Name == "Grogg Shoppe"), Organizer = Organizers.Single(a => a.EmailAddress == "toddj.liddy@gmail.com")},
            }.ForEach(a => context.Events.Add(a));
        }
    }
}