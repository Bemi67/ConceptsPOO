namespace ConceptsPOO
{
    // : <--- marcan HERENCIA
    public class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }
        public override decimal GetValueToPay()
        {
            return Salary;
        }
        public override string ToString()
        {
            // en la doble interpolacion le digo que ocupe 18 caracteres
            return $" {base.ToString()}" +
                $"\n\t Valute to pay........: {$"{GetValueToPay():C2}", 18}";
        }
    }
}
