using IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class DogService : IDogService
    {
        public string GJ()
        {
            return "汪汪";
        }
    }
}
