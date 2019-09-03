using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripTracker.Model;

namespace TripTracker.Models
{
    public class Repository
    {
        private List<Trip> MyTrips = new List<Trip>
        {
            new Trip
            {
                Id = 1,
                Name = "My Summit",
                StartDate = new DateTime(2019, 3,5),
                EndDate = new DateTime(2019, 3,8)
            },
                        new Trip
            {
                Id = 2,
                Name = "My Journey",
                StartDate = new DateTime(2019, 4,5),
                EndDate = new DateTime(2019, 8,8)
            }
        };

        public List<Trip> Get()
        {
            return MyTrips;
        }

        public Trip Get(int id)
        {
            return MyTrips.First(t => t.Id == id);
        }

        public void Add(Trip newTrip)
        {
            MyTrips.Add(newTrip);
        }

        public void Update(Trip tripToUpdate)
        {
            MyTrips.Remove(MyTrips.First(t => t.Id == tripToUpdate.Id));
            Add(tripToUpdate);
        }

        public void Remove(int id)
        {
            MyTrips.Remove(MyTrips.First(t => t.Id == id));
        }
    }
}
