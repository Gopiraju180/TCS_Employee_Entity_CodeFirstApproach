using System.ComponentModel.DataAnnotations;

namespace TCS_Employee_Entity_CodeFirstApproach.Entites
{
    public class Departement
    {
        [Key]
        public int deptid { get; set; }
        public string deptname { get; set; }
        public string deptlocation { get; set; }
    }
}
