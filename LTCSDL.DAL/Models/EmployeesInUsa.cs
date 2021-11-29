using System;
using System.Collections.Generic;

#nullable disable

namespace LTCSDL.DAL.Models
{
    public partial class EmployeesInUsa
    {
        public int EmployeeId { get; set; }
        public string Fullname { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public string Address { get; set; }
    }
}
