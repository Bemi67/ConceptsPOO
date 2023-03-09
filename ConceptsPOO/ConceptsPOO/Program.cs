using ConceptsPOO;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");

//para probar parte 1
//try
//{
//	Console.WriteLine(new Date(2024, 2, 29));
//	Console.WriteLine(new Date(1974, 9, 23));
//	Console.WriteLine(new Date(1985, 11, 31));

//}
//catch (Exception error)
//{

//	Console.WriteLine(error.Message);
//}

Employee employee1 = new SalaryEmployee()
{
    Id = 101,
    FirstName = "Sandra",
    LastName = "Morales",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary = 2312412.45M
};
Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee()
{
    Id = 2301,
    FirstName = "Patricia",
    LastName = "Gutierrez",
    BirthDate = new Date(1980, 2, 12),
    HiringDate = new Date(2014, 1, 12),
    IsActive = true,
    Sales = 32000000M,
    CommissionPercentage = 0.03F
    
};
Console.WriteLine(employee2);