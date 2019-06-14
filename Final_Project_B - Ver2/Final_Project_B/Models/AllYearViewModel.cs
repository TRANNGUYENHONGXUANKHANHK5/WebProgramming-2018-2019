using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Final_Project_B.Models
{
    public class AllYearViewModel
    {
        [DisplayName("Mã học sinh")]
        public string StudentID { get; set; }
        [DisplayName("Lớp")]
        public string ClassID { get; set; }
        [DisplayName("Tên")]
        public string LastName { get; set; }
        [DisplayName("Họ")]
        public string FirstName { get; set; }
        public Nullable<double> TBHK1 { get; set; }
        public Nullable<double> TBHK2 { get; set; }
        public Nullable<double> TBHCN { get; set; }
        //public string HocLuc { get; set; }
        //public string HanhKiem { get; set; }
    }
}