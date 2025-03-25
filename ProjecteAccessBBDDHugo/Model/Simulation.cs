using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjecteAccessBBDDHugo.Model
{
    public class Simulation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Tipus { get; set; }
        public double HoresSol { get; set; }
        public double VelocitatVent { get; set; }
        public double CabalAigua { get; set; }
        public double Rati { get; set; }
        public double EnergiaGenerada { get; set; }
        public double CostKWh { get; set; }
        public double PreuKWh { get; set; }
        public string DataHora { get; set; }
    }
}
