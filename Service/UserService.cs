using IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class UserService : IUserService
    {
       public IDogService dogService { get; set; }
        public bool CheckAge(int age)
        {
            string a= dogService.GJ();
            return true;
        }

        public bool CheckName(string name)
        {
           
            return false;
        }
    }
}
