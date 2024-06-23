using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Child_mg.DTO
{
    internal class ChildClassUserStructure
    {
        public string Comment {  get; set; }
        public string Parents {  get; set; }
        public string TeacherName { get; set; }
        public string phoneuser  {  get; set; }
        public int ChildId { get; set; }
        public string ChildName { get; set; }
        public DateOnly? ChildDate { get; set; }
        public int? ChildStatus { get; set; }
        public string ChildGender { get; set; }
        public string ClassName { get; set; }
        public string UserAddress { get; set; }
        public int ClassId { get; set; }

        public string Parentsuser { get; set; }

        public string Parentspass { get; set; }


    }
}
