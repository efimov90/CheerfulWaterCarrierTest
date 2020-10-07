using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheerfulWaterCarrier.Models
{
    public class EmployeeModel
    {
        public enum ESex
        {
            Female,
            Male
        }

        public int? EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public ESex Sex { get; set; }
        public int? SubdivisionId { get; set; }
    }
}
