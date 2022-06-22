using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC323_project.Users
{
   public abstract class User
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        
        public User(string _userid, string _email, string _password, string _firstname, string _lastname, string _address)
        {
            Id = _userid;
            Password = _password;
            Email = _email;
            Firstname = _firstname;
            Lastname = _lastname;
            Address = _address;
        }
       public virtual string printinfo() {
            StringBuilder a = new StringBuilder();

            a.Append($" ID={Id } Email={Email} First Name={Firstname}  Last Name {Lastname} Address {Address}");
            a.AppendLine();
            return a.ToString();


        }
    }
}

