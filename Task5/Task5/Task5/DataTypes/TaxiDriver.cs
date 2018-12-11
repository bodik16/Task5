using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.DataTypes
{
    [Table("Drivers")]
    public class TaxiDriver
    {
        [Key]
        public int DriverId { get; set; }

        [MaxLength(50)]
        [Required]
        public string Surname { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string CarNumber { get; set; }

        [Required]
        public int Experience { get; set; }

        [Required]
        public int CostPerMinute { get; set; }

        [Required]
        public double PayCheck { get; set; }

        public TaxiDriver()
        {
            PayCheck = 0;
        }
        public TaxiDriver(string _surname, string _name, int _age, string _carNumber, int _experience, int _cost, double _pay = 0)
        {
            Surname = _surname;
            Name = _name;
            Age = _age;
            CarNumber = _carNumber;
            Experience = _experience;
            CostPerMinute = _cost;
            PayCheck = _pay;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4} {5} {6} {7}", DriverId, Surname, Name, Age, CarNumber, Experience, CostPerMinute, PayCheck);
        }
    }
}
