// esot va ser una clase abstracta, quiere decir que no existe, otras clases heredan de esta, pero no puedo definir objetos de la misma
// va a tener campos y compenen a la clase
//cuando se hereda de una clase abstracta se heredan todos sus métodos

namespace ConceptsPOO
{
    public abstract class Employee : IPay
    {
        // prop para crear propiedad
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Date BirthDate { get; set; }
        public Date HiringDate { get; set; }
        public bool IsActive { get; set; }
        public abstract decimal GetValueToPay();
        public override string ToString()
        {
            return $"{Id} - {FirstName} {LastName}," +
                $" Birth: {BirthDate}," +
                $" Hired: {HiringDate}," +
                $" Is active: {IsActive}";
        }
    }
}
