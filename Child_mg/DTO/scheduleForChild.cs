using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Child_mg.DTO
{
    internal class scheduleForChild
    {
        public string ClassName { get; set; }

        public string TeacherName { get; set; }

        public string Lesson { get; set; }

        public string SubjectName { get; set; }

        public string ChildName { get; set; }

        public int ChildId { get; set; }

        public DateOnly? Date { get; set; }

        public int? status { get; set; }

        public int? idschedule { get; set; }

        public int? idscheduleinfo { get; set; }
    }
}
