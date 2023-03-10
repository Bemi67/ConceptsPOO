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
//Console.WriteLine(employee1);

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
//Console.WriteLine(employee2);

Employee employee3 = new HourlyEmployee()
{
    Id = 3671,
    FirstName = "Gonzalo",
    LastName = "Cardona",
    BirthDate = new Date(1985, 3, 11),
    HiringDate = new Date(2017, 11, 2),
    IsActive = true,
    HourValue = 12356.57M,
    Hours = 123.5F

};
//Console.WriteLine(employee3);

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 6791,
    FirstName = "Bernabé",
    LastName = "Michel",
    BirthDate = new Date(1991, 7, 8),
    HiringDate = new Date(2011, 4, 18),
    IsActive = true,
    Base = 890123.34M,
    Sales = 89990000M,
    CommissionPercentage = 0.015F

};
//Console.WriteLine(employee4);

//fomra 1

//ICollection<Employee> employees = new List<Employee>();
//employees.Add(employee1);
//employees.Add(employee2);
//employees.Add(employee3);
//employees.Add(employee4);

//forma 2, 
ICollection<Employee> employees = new List<Employee>()
{
    employee1,employee2, employee3, employee4
};
decimal payroll = 0;
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}
Console.WriteLine("                                  ===============");
Console.WriteLine($"TOTAL                          {$"{payroll:C2}",18}");

Invoice invoice1 = new Invoice()
{
    Description = "Celular",
    Id = 1,
    Price = 6300000M,
    Quantity = 6
};

Invoice invoice2 = new Invoice()
{
    Description = "Carne",
    Id = 2,
    Price = 90000M,
    Quantity = 12.4F
};

Console.WriteLine(invoice1);
Console.WriteLine(invoice2);