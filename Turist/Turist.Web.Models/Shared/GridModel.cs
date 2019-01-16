using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turist.Web.Models.Shared
{
    public class GridModel
    {
        public int CompanyNumber { get; set; }
        public decimal ResidenceCoefficient { get; set; }
        public decimal FoodCoefficient { get; set; }
        public decimal TransportationCoefficient { get; set; }
        public decimal ExcursionCoefficient { get; set; }
        public decimal AverageRateCoefficient { get; set; }
    }
}
