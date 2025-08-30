using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace EmployeeDataApp.Models
{
        [Table("Employees")]
        public class Employee { 
        
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }

            [Required]
            [StringLength(50)]
            public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Job { get; set; }

            [Range(0, double.MaxValue)]
            public double Salary { get; set; }
            public byte[]? Photo { get; set; } = null;


        // this is a class's thing not shared with DB like a method to display the stored pic in Photo array
        [NotMapped]
        public Image DisplayPhoto
            {
                get => Photo != null ? Helpers.ImageHelper.ConvertByteArrayToImage(Photo) : null;
                set => Photo = value != null ? Helpers.ImageHelper.ConvertImageToByteArray(value) : null;
            }
        }
}
