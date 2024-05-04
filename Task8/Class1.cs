using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task8.Program;

namespace Task8
{
    internal class Class1
    {
//Task 8
//Question 1
//Service Implementation
        public class CourierUserServiceImpl : ICourierUserService
        {
            protected CourierCompany companyObj;

            public CourierUserServiceImpl(CourierCompany companyObj)
            {
                this.companyObj = companyObj;
            }

            public void AddUser(string username, string password, string email)
            {
            }

            public void RemoveUser(string username)
            {
            }

            public void UpdateUserPassword(string username, string newPassword)
            {

            }

        }
////Task 8
//Question 2
//Service Implementation
        public class CourierAdminServiceImpl : CourierUserServiceImpl, ICourierAdminService
        {
            public CourierAdminServiceImpl(CourierCompany companyObj) : base(companyObj)
            {
                
            }

            public void AddCourierCompany(string companyName)
            {
                
            }

            public void RemoveCourierCompany(string companyName)
            {
                
            }

        }
        ////Task 8
        //Question 3
        //Service Implementation
        public class CourierAdminServiceCollectionImpl : CourierUserServiceCollectionImpl, ICourierAdminService
        {
            public CourierAdminServiceCollectionImpl(CourierCompanyCollection companyObj) : base(companyObj)
            {
                
            }

            public void AddCourierCompany(string companyName)
            {
                
            }

            public void RemoveCourierCompany(string companyName)
            {
            }

           
        }
        static void Main(string[] args)
        {
            
        }
    }
}
