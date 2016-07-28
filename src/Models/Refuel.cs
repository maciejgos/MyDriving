namespace MyDriving.Models
{
    public class Refuel
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public int Liters { get; set; }

        public decimal PricePerLiter { get; set; }

        public int Mileage { get; set; }

        public virtual Vehicle Vehicle { get; set; }
    }
}