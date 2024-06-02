using StaffManagementPractical.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffManagementPractical
{
    public class Company
    {
        List<Staff> staff;
        List<MyAdmin> admin;
        public DateTime DateTime = DateTime.Today.AddHours(9);
        DateTime constantArrivalTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 9, 0, 0);
        DateTime constantClockOutTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 17, 0, 0);
        DateTime expectedArrivalTime = new DateTime();
        
        public void Login(string nameOrEmail, string password, Role role)
        {
            if (role == Role.Staff)
            {
               


                var getStaff = staff.FirstOrDefault(x => x.StaffName == nameOrEmail || x.Email == nameOrEmail && x.Password == password);

               
                var add = Sum(1,3);
                Console.WriteLine(add);


                if (getStaff != null)
                {
                    getStaff.IsloggedIn = true;
                    getStaff.IsClockedIn = true;
                    getStaff.TimeOfArrival = DateTime.Now;
                    getStaff.IsLate = TrackLateArrival(getStaff.TimeOfArrival) ? true : false;
                    Console.WriteLine($"Good Day! {getStaff.StaffName} , you have successfully LoggedIn");
                }
                else
                {
                    Console.WriteLine("Wrong Login details!");
                }
            }
            else if (role == Role.Admin)
            {
                var getAdmin = admin.FirstOrDefault(x => x.StaffName == nameOrEmail || x.Email == nameOrEmail && x.Password == password);
                if (getAdmin != null)
                {
                    getAdmin.IsloggedIn = true;
                    getAdmin.IsClockedIn = true;
                    getAdmin.TimeOfArrival = DateTime.Now;
                    getAdmin.IsLate = TrackLateArrival(getAdmin.TimeOfArrival) ? true : false;
                    Console.WriteLine($"Good Day! {getAdmin.StaffName} , you have successfully LoggedIn");
                }
                else
                {
                    Console.WriteLine("Wrong Login details!");
                }
            }

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
        public bool TrackLateArrival(DateTime timeOfArrival)
        {
            if(timeOfArrival > constantArrivalTime)
            {
                Console.WriteLine(" Good morning, You are late for work. ");
                return true;
            }
            else
            {
                Console.WriteLine($" Good Morning, Welcome to work.");
                return false;
            }
        }
        public static int Sum(int num1, int num2)
        {
            return num1 + num2; 
        }
        public void Clockout(DateTime TimeOfArrival )
        {
            var clockout = TimeOfArrival - constantClockOutTime;
            if (clockout <  constantClockOutTime )
        }
    }
}


