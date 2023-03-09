namespace ConceptsPOO
{
    public class CommissionEmployee : Employee
    {
        // float porcentaje
        public float CommissionPercentage { get; set; }

        public decimal Sales { get; set; }

        public override decimal GetValueToPay()
        {
            return Sales * (decimal)CommissionPercentage;
        }
        public override string ToString()
        {
            // C2 formato plata con 2 decimales y P2 formato de porcentaje con 2 decimales dan formato
            return $"{base.ToString()}" +
                $"\n\tCommissionPercentage {$"{CommissionPercentage:P2}", 18}" +
                $"\n\tSale................: {$"{Sales:C2}", 18}" +
                $"\n\tValue to pay........: {$"{GetValueToPay():C2}", 18}";
        }
    }
}
