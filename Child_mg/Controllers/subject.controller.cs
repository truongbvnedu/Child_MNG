using Child_mg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Child_mg.Controllers
{
    
    internal class subjectControlller
    {
        
        ChildDbContext db = new ChildDbContext();
        private static subjectControlller instance;
        public static subjectControlller Instance { 
            get { if (instance == null) instance = new subjectControlller();  return instance; }
            private set { instance = value; }
        }
        public subjectControlller() { }

        public  void addsubject(Subject sb)
        {
            db.Subjects.Add(sb);
            db.SaveChanges();

        }
        public List<Subject> loaddata()
        {
            var result = from c in db.Subjects
                         select c;
           return result.ToList();
        }
        public void deletesubject(int id)
        {
            Subject subject = db.Subjects.Where(p => p.Id == id).SingleOrDefault();
            db.Subjects.Remove(subject);
            db.SaveChanges();
        }
        public void editsubject(int id, string name,int status)
        {
            Subject subject = db.Subjects.Find(id);
            subject.Name = name;
            subject.Status = status;
            db.SaveChanges();
        }
        public List<Subject> loadsubject()
        {
            List<Subject> subjects = db.Subjects.Where(p => p == p).ToList();
            return subjects;
        }
    }
}
