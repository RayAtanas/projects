using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC323_project.Users.Admin
{
    public class Admin : User
    {
        int Salary { get; set; }
        int year_of_entrance { get; set; }
        int Number_of_years { get; set; }
        List<User> user_list { get; set; }
        

        public Admin(string _userid, string _email, string _password, string _firstname, string _lastname, string _address, int _salary, int _number_of_years) : base(_userid, _email, _password, _firstname, _lastname, _address)
        {
            Number_of_years = _number_of_years;
            _number_of_years = DateTime.Now.Year - year_of_entrance;
            void salary_augmentation()
            {

                if (Number_of_years < 2)
                {
                    Salary = 1500;
                }
                else if (Number_of_years >= 2)
                {
                    Salary = 2000;
                }
                

            }
        }

        void remove_user(User Id)
        {
            user_list.Remove(Id);

        }
        public override string printinfo() 
        {
            return base.printinfo();
            this.Firstname = "Admin";
            this.Password = "12345678";
        }
    }
}