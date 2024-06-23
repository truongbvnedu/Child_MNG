using Child_mg.DTO;
using Child_mg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Child_mg.Controllers
{
    internal class scheduleController
    {

        ChildDbContext db = new ChildDbContext();
        private static scheduleController instance;
        public static scheduleController Instance
        {
            get { if (instance == null) instance = new scheduleController(); return instance; }
            private set { instance = value; }
        }
        public scheduleController() { }

        public void addsechdule(string datestring, int classid)
        {
            DateTime dateTime;
            DateTime.TryParse(datestring , out dateTime);
            DateOnly dateadd = DateOnly.FromDateTime(dateTime);
            Schedule schedule = new Schedule() { IdClass = classid, Date = dateadd,Status = 0};
            db.Schedules.Add(schedule);
            db.SaveChanges();
         
        }
        public void addscheduleinfo(int subjectid , string lesson, int status, string datestring, int classid)
        {
            DateTime dateTime;
            DateTime.TryParse(datestring, out dateTime);
            DateOnly dateadd = DateOnly.FromDateTime(dateTime);
            Schedule sh = db.Schedules.Where(p=> p.Date == dateadd && p.IdClass ==classid ).FirstOrDefault();

            ScheduleInfo scheduleinfo = new ScheduleInfo() { IdSubject = subjectid , Name = lesson , Status = status,IdSchedule = sh.Id };
            db.ScheduleInfos.Add(scheduleinfo);
            db.SaveChanges();
        }
        public void addtrueschedule(string datestring, int classid, int subjectid, string lesson, int status)
        {
            DateTime dateTime;
            DateTime.TryParse(datestring, out dateTime);
            DateOnly dateadd = DateOnly.FromDateTime(dateTime);
            Schedule schedulecheck = (from c in db.Schedules
                                      where c.Date == dateadd && c.IdClass == classid
                                      select c).FirstOrDefault() ;
            ScheduleInfo lessoncheck = db.ScheduleInfos.Where(p=>p.IdSchedule == schedulecheck.Id && p.Name == lesson).FirstOrDefault();
            if (schedulecheck == null )
            {
                addsechdule(datestring, classid);
                addscheduleinfo(subjectid, lesson, status,datestring,classid);
                MessageBox.Show("Thêm Ngày thành công");
            }
            else if (lessoncheck == null)
            {
                addscheduleinfo(subjectid, lesson, status, datestring, classid);
                MessageBox.Show("Thêm tiết thành công");
            }
            else
            {
                MessageBox.Show("Thêm tiết thất bại trùng tiết trong ngày");
            }

        }
        public void fixschedule(string datestring, int classid, int subjectid, int status,int idschedule, int idscheduleinfo)
        {
            DateTime dateTime;
            DateTime.TryParse(datestring, out dateTime);
            DateOnly update = DateOnly.FromDateTime(dateTime);

            Schedule schedule = db.Schedules.Find(idschedule);
            schedule.Date = update;
            schedule.IdClass = classid; 
            ScheduleInfo scheduleInfo = db.ScheduleInfos.Find(idscheduleinfo);
            scheduleInfo.Status = status;
            scheduleInfo.IdSubject = subjectid;
            db.SaveChanges();
            MessageBox.Show("Chỉnh sửa thành công");
        }
        public void checklesson(string datestring, int classid, int subjectid, int status,int idschedule, int idscheduleinfo)
        {
            DateTime dateTime;
            DateTime.TryParse(datestring, out dateTime);
            DateOnly fixdate = DateOnly.FromDateTime(dateTime);
            Schedule schedule = db.Schedules.Where(p=> p.Date == fixdate ).FirstOrDefault();

            List<ScheduleInfo> scheduleInfo = db.ScheduleInfos.Where(p=>p.IdSchedule == schedule.Id).ToList();
            int checkinfo = scheduleInfo.Count;
            fixschedule(datestring,classid,subjectid,status,idschedule,idscheduleinfo);
            
        }
        public void deletelesson(int idscheduleinfo)
        {
            ScheduleInfo schedule = db.ScheduleInfos.Find(idscheduleinfo);
            db.ScheduleInfos.Remove(schedule);
            db.SaveChanges();
            MessageBox.Show("Xoá tiết thành công ");

        }
    }
}
