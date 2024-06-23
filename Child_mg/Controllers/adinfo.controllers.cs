using Child_mg.DTO;
using Child_mg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Child_mg.Controllers
{
    internal class adinfoController
    {
        ChildDbContext db = new ChildDbContext();
        private static adinfoController instance;
        public static adinfoController Instance
        {
            get { if (instance == null) instance = new adinfoController(); return instance; }
            private set { instance = value; }
        }
        public adinfoController() { }
        public List<ChildClassUserStructure> LoadInformation()
        {
            var query = (from child in db.Children
                         join cls in db.Classes on child.IdClass equals cls.Id
                         join user in db.Users on cls.IdUser equals user.Id
                         select new ChildClassUserStructure
                         {
                             phoneuser = user.Phone,
                             ChildId = child.Id,
                             ChildName = child.Name,
                             ChildDate = child.Date,
                             ChildStatus = child.Status,
                             ChildGender = child.Gender,
                             ClassName = cls.Name,
                             TeacherName = user.Name,
                             UserAddress = user.Address 
                         }).ToList();
            return query;

        }
        public List<ChildClassUserStructure> findfinfo()
        {
            var query = (from child in db.Children
                         join cls in db.Classes on child.IdClass equals cls.Id
                         join user in db.Users on cls.IdUser equals user.Id
                         select new ChildClassUserStructure
                         {
                             phoneuser = user.Phone,
                             ChildId = child.Id,
                             ChildName = child.Name,
                             ChildDate = child.Date,
                             ChildStatus = child.Status,
                             ChildGender = child.Gender,
                             ClassName = cls.Name,
                             TeacherName = user.Name,
                             UserAddress = user.Address
                         }).ToList();
            return query;
        }
        public void editinfo(int id,string name ,int classid, string gender, string address, string birtday)
        {
            Child childa = db.Children.Find(id);
            Class classes = db.Classes.Find(childa.IdClass);
            User user = db.Users.Find(classes.IdUser);
            childa.Name = name; 
            childa.Gender = gender;
            user.Address = address;
            childa.IdClass = classid ;
            db.SaveChanges();
        }
        public void addinfo(string phone)
        {
            User user = db.Users.Find(phone);
            Child addchile = db.Children.Find(user.Id);
           
        }
     
    }
}
