using Child_mg.DTO;
using Child_mg.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Child_mg.Controllers
{

    internal class childController
    {
        ChildDbContext db = new ChildDbContext();
        private static childController instance;
        public static childController Instance
        {
            get { if (instance == null) instance = new childController(); return instance; }
            private set { instance = value; }
        }
        public childController() { }
        public List<ChildClassUserStructure> LoadInformation(string username , string password)
        {
            
            var query = (from child in db.Children
                         join cls in db.Classes on child.IdClass equals cls.Id
                         join teacher in db.Users on cls.IdUser equals teacher.Id
                         join parent in db.Users on child.IdUsers equals parent.Id
                         where parent.Account == username && parent.Password == password
                         select new ChildClassUserStructure
                         {
                             ChildId = child.Id,
                             ChildName = child.Name,
                             ChildDate = child.Date, 
                             ChildStatus = child.Status,
                             ChildGender = child.Gender,
                             ClassName = cls.Name,
                             TeacherName = teacher.Name,
                             UserAddress = parent.Address,
                             Comment = child.Comment
                         }).ToList();
            return query;
        }

        public List<scheduleForChild> LoadSchedules(int idchild, string mtbdate)
        {
            DateTime mtbdatechange;
            DateTime.TryParse(mtbdate, out mtbdatechange);
           
            DateOnly date = DateOnly.FromDateTime(mtbdatechange);
            var query = (from child in db.Children
                        join cls in db.Classes on child.IdClass equals cls.Id
                        join teacher in db.Users on cls.IdUser equals teacher.Id
                        join sch in db.Schedules on cls.Id equals sch.IdClass
                        join sch_info in db.ScheduleInfos on sch.Id equals sch_info.IdSchedule
                        join subject in db.Subjects on sch.IdClass equals subject.Id
                        where child.Id == idchild  && sch.Date == date
                        select new scheduleForChild
                        {
                            ChildName = child.Name,
                            TeacherName = teacher.Name,
                            SubjectName = subject.Name,
                            Lesson = sch_info.Name,
                            status = sch_info.Status,
                            ClassName = cls.Name,
                            Date = sch.Date
                        }).ToList();
            return query;
        }
        public List<ChildClassUserStructure> findchild(string phoneuser)
        {
            var query = (from child in db.Children
                         join cls in db.Classes on child.IdClass equals cls.Id
                         join teacher in db.Users on cls.IdUser equals teacher.Id
                         join parent in db.Users on child.IdUsers equals parent.Id
                         where parent.Phone == phoneuser
                         select new ChildClassUserStructure
                         {
                             ChildId = child.Id,
                             ChildName = child.Name,
                             ChildDate = child.Date,
                             ChildStatus = child.Status,
                             ChildGender = child.Gender,
                             ClassName = cls.Name,
                             TeacherName = teacher.Name,
                             Parents = parent.Name,
                             UserAddress = parent.Address
                         }).ToList();
            return query;
        }
        public List<ChildClassUserStructure> childlist(string nameclass)
        {
            var query = (from child in db.Children
                         join cls in db.Classes on child.IdClass equals cls.Id
                         join teacher in db.Users on cls.IdUser equals teacher.Id
                         join parent in db.Users on child.IdUsers equals parent.Id
                         where cls.Name == nameclass
                         select new ChildClassUserStructure
                         {
                             ClassId = cls.Id,
                             ChildId = child.Id,
                             ChildName = child.Name,
                             ChildDate = child.Date,
                             ChildStatus = child.Status,
                             ChildGender = child.Gender,
                             ClassName = cls.Name,
                             TeacherName = teacher.Name,
                             Parents = parent.Name,
                             UserAddress = parent.Address
                         }).ToList();
            return query;
        }
            public void checkatten(int checkatten,int id)
            {
                Child child = db.Children.Find(id);
                child.Status = checkatten;
                db.SaveChanges();
            }
        public void addchild(string phone,string name,string gender,int idclass)
        {
            User user = db.Users.Find(phone);
            int userid = user.Id;
            Child addchild =  new Child() { Name = name , Gender =gender ,IdUsers = userid, IdClass = idclass };
            db.Children.Add(addchild);
            db.SaveChanges();
        }
        public List<Child> loadchild(string username,string password)
        {
            User user = db.Users.Where(p=> p.Account == username && p.Password == password).SingleOrDefault();
           
            int iduser = user.Id;
            List<Child> child = db.Children.Where(p=> p.IdUsers == iduser).ToList();
            return child ;
        }

        public List<TeacherComment> commentteacher(int idchild )
        {
            var teacher = (from child in db.Children
                           join cls in db.Classes on child.IdClass equals cls.Id
                           join tch in db.Users on cls.IdUser equals tch.Id
                           where cls.Id == idchild
                           select new TeacherComment
                           {
                               ChildName = child.Name,
                               ClassName = cls.Name,
                               Comment = child.Comment,
                               Date = child.Date,
                               gender = child.Gender,
                               teachername = tch.Name,
                               identity = tch.IdentityId,
                               idClass = cls.Id,
                               idChild = child.Id
                           }

                           ).ToList();
            return teacher ;

        }
        
        public List<Class> loadclassteacher (string username, string password)
        {
            User user = db.Users.Where(p=>p.Account == username && p.Password == password).SingleOrDefault();
            int iduser = user.Id;
            List<Class> classes = db.Classes.Where(p=>p.IdUser == iduser).ToList();
            return classes ;
        }
       public void commentsend(string comment, int idchild)
        {
            Child child = db.Children.Find(idchild);
            child.Comment = comment;
            db.SaveChanges();
            MessageBox.Show("Cập nhật thành công !");
        }
        public List<ChildClassUserStructure> loadclassteacherteach(string uername,string password)
        {
            var query = (from cls in db.Classes
                         join teacher in db.Users on cls.IdUser equals teacher.Id
                         where teacher.Account == uername && teacher.Password == password
                         select new ChildClassUserStructure
                         {
                             ClassName = cls.Name,  
                             ClassId = cls.Id,
                         }).ToList();
            return query;
        }
        public List<scheduleForChild> loadscheduleforteacher (int idlcass, string mtbdate)
        {
            DateTime mtbdatechange;
            DateTime.TryParse(mtbdate, out mtbdatechange);

            DateOnly datec = DateOnly.FromDateTime(mtbdatechange);
            var query = (from user in db.Users
                         join cls in db.Classes on user.Id equals cls.IdUser
                         join sch in db.Schedules on cls.Id equals sch.IdClass
                         join sch_info in db.ScheduleInfos on sch.Id equals sch_info.IdSchedule
                         join subject in db.Subjects on sch_info.IdSubject equals subject.Id
                         where cls.Id == idlcass && sch.Date == datec
                         select new scheduleForChild
                         {
                             idschedule = sch.Id,
                             idscheduleinfo = sch_info.Id,
                             TeacherName = user.Name,
                             SubjectName = subject.Name,
                             Lesson = sch_info.Name,
                             status = sch_info.Status,
                             ClassName = cls.Name,
                             Date = sch.Date
                         }).ToList();

            return query;
        }
    }
}
