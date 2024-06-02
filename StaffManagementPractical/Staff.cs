using StaffManagementPractical.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffManagementPractical
{
    public class Staff
    {
        public string StaffName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int StaffNumber { get; set; }
        public DateTime HireDate { get; set; }
        public bool IsClockedIn { get; set; }
        public bool IsClockedOut { get; set; }
        public DateTime TimeOfArrival { get; set; }
        public DateTime ClockoutTime { get; set; }
        public bool IsLate { get; set; }
        public bool IsActive { get; set; }
        public bool IsloggedIn { get; set; }
        public Role Role { get; set; }
    }
}
