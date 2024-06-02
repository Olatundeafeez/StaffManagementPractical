using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffManagementPractical
{
    public class Company
    {
        List<Staff> staff = new List<Staff>();
        List<MyAdmin> admin = new List<MyAdmin>();
        public DateTime DateTime = DateTime.Today.AddHours(9);
        TimeSpan arrivalTime = new TimeSpan(8,59,59);
        DateTime expectedArrivalTime = new DateTime();        
        
        public void Login(string nameOrEmail, string password)
        {
             var getStaff = staff.FirstOrDefault( x => x.StaffName == nameOrEmail || x.Email == nameOrEmail && x.Password == password);
            if (getStaff != null  )
            {
                getStaff.IsloggedIn = true;
                Console.WriteLine($"Good Day! {getStaff.StaffName} , you have successfully LoggedIn");
            }
            else
                Console.WriteLine("Wrong Login details!");
        }
        public void LogOut(string nameOrEmail , string password)
        {
            var logout = staff.FirstOrDefault(x => x.StaffName == nameOrEmail || x.Email == nameOrEmail && password == password );
            if (staff == null)
            {
                logout.IsloggedIn = false;
                Console.WriteLine($" LoggedOut{logout.StaffName} ");
            }
            else
                Console.WriteLine("Wrong logout details.");
        }
        public void TrackLateArrival()
        {
            if (arrivalTime == arrivalTime)
            {
                Console.WriteLine($" Good Morning, Welcome to work.");
            }
            else
                Console.WriteLine(" Good morning, You are late for work. ");
        }
        public void StaffMember(int Admin,string Staff)
        {

        }
    }
}
