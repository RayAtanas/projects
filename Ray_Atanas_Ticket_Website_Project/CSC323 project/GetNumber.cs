using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC323_project
{
    class GetNumber
    {
        private static GetNumber instance;
        private GetNumber() { }
        public static GetNumber get_instance()
        {
            if(instance== null)
            {
                instance = new GetNumber();

            }
            return instance;

        }
        private static int Id;
        public List<int> ids = new List<int> { };
        public int get_number()
        {
            Random rand = new Random();
            int num = rand.Next(0, 100);
            bool found = true;
            foreach (var id in ids)
                if (num == id) {
                    found = false;
                        
            }
            if (found == true)
                return Id;
            else
              return  get_number();
        }
    }

}
