using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Child_mg.DTO
{
    internal class TeacherComment
    {
        public string ChildName { get; set; }

        public int idClass { get; set; }
        public int idChild { get; set; }
        public string ClassName { get; set; }

        public string Comment { get; set; }

        public DateOnly? Date { get; set; }
        public string gender { get; set; }

        public string teachername { get; set; }

        public string identity { get; set; }
    }
}
