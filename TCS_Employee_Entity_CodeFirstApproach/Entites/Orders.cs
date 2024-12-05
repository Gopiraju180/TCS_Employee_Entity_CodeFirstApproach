using System.ComponentModel.DataAnnotations;

namespace TCS_Employee_Entity_CodeFirstApproach
{
    public class Orders
    {
        [Key]
        public int orderid { get; set; }
        public string ordername { get; set; }
        public string orderlocation { get; set; }
    }
}
