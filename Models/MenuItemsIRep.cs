using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Module3ReservationAssignment.Models
{
    public interface MenuItemsIRep
    {
        IEnumerable<MenuItems> MenuItems { get; }
        MenuItems this[int id] { get; }
        MenuItems AddMenuItems(MenuItems MenuItems);
        MenuItems UpdateMenuItems(MenuItems MenuItems);
        void DeleteMenuItems(int id);
    }
}
