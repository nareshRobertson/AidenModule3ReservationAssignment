using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Module3ReservationAssignment.Models
{
    public class Repository : IRepository
    {
       
        
            private Dictionary<int, Reservation> items;

            public Repository()
            {
                items = new Dictionary<int, Reservation>();
                new List<Reservation> {
                new Reservation {Id=1, Name = "Bob Loblaw", date = 01-01-2020, MenuItems="" },
                }.ForEach(r => AddReservation(r));
            }

            public Reservation this[int id] => items.ContainsKey(id) ? items[id] : null;

            public IEnumerable<Reservation> Reservations => items.Values;

            public Reservation AddReservation(Reservation reservation)
            {
                if (reservation.Id == 0)
                {
                    int key = items.Count;
                    while (items.ContainsKey(key)) { key++; };
                    reservation.Id = key;
                }
                items[reservation.Id] = reservation;
                return reservation;
            }

            public void DeleteReservation(int id) => items.Remove(id);

            public Reservation UpdateReservation(Reservation reservation) => AddReservation(reservation);
        
    }
}
