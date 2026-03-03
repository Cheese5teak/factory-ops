using System.ComponentModel.DataAnnotations;

namespace FactoryOps.Models
{
    public class WorkOrder
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string PartNumber { get; set; } = string.Empty;

        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }

        [Required]
        public string status { get; set; } = "Planned";

        public DateTime DueDate { get; set; }

        public WorkOrder()
        {
            
        }
    }
}
