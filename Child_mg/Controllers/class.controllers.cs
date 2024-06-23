using Child_mg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Child_mg.Controllers
{
    internal class classController
    {
        ChildDbContext db = new ChildDbContext();
        private static classController instance;
        public static classController Instance
        {
            get { if (instance == null) instance = new classController(); return instance; }
            private set { instance = value; }
        }
        public classController() { }

        public List<Class> loadclass()
        {
            var classes = from c in db.Classes
                       select c;
            return classes.ToList();
        }
    }
}
