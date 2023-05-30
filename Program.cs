internal class Program
{

    public static void Main(string[] args)
    {
        List<Employee> employees = new() //список сотрудников
        {
            new Employee("Миклашевский Данила Сергеевич", 1, 5555),
            new Employee("Жуков Антон Павлович ", 1, 6666),
            new Employee("Погорелов Артем Александрович", 2, 4444),
            new Employee("Шевченко Артем Денисович", 2, 1111),
            new Employee("Шевченко Макар Николаевич", 3, 2222),
            new Employee("Нехаева Эвелина Владимировна", 3, 3333),
            new Employee("Ламтюгина Олеся Ивановна", 4, 8888),
            new Employee("Лагунов Данил Сереевич", 4, 7777),
            new Employee("Лапин Александр Дмитриевич", 5, 9999),
            new Employee("Ларин Данила Васильевич", 5, 1010)
        };

        void EmployeeInfo() // информация по сотрудникам
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($"Cотрудник под номером {emp._id} - {emp.Fio}, работающий в отделе " +
                    $"{emp.Department} получает зарплату в размере" +
                    $" {emp.Salary}");
            }
        }
        void EmployeeSalary() //суммарные зтраты на зп в месяц
        {
            double sum = 0;
            foreach (Employee emp in employees)
            {
                sum += emp.Salary;
            }
            Console.WriteLine($"Сумма затрат на зарплаты в месяц: {sum}");

        } 
        void MinSalary() //минимальная за сотрудника
        {
            Console.WriteLine($"Человек с самой минимальной зарплатой {employees.Min(e => e.Salary + "рублей: " + e.Fio)} ");
        }
        void MaxSalary() //максимальная зп сотрудника
        {
            Console.WriteLine($"Человек с самой максимальной зарплатой {employees.Max(e => e.Salary + "рублей: " + e.Fio)} ");
        }
        void AvgSalary() //среднее зп по офису
        {
            Console.WriteLine($"Среднее значение зарплат: {employees.Average(e => e.Salary)}");
        }
        void EmlployeeFio() //ФИО сотрудников
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($"ФИО сотрудника: {emp._id} {emp.Fio}");
            }

        }
        void SalaryPrecent() //индексация зп на определенный процент
        {
            Console.WriteLine("Введите процент на который увеличится зарплата работников: ");
            double percent = double.Parse(Console.ReadLine());
            double salary;
            foreach (var emp in employees)
            {
                salary = emp.Salary + (emp.Salary / percent);

                Console.WriteLine($"Теперь зарплата сотрудника {emp.Fio} составляет: {salary} рублей");
            }
        }
        void DepartmentEmployee() //зп по отделам
        {

            Console.WriteLine("Введите номер отдела:");
            double departmentID = double.Parse(Console.ReadLine());
            foreach (var emp in employees)
            {
                if (emp.Department == departmentID)
                {
                    Console.WriteLine($"Сотрудник {emp.Fio} из {emp.Department} отдела получает: {emp.Salary}");
                }
            }
        }
        void DepartamentSalaryMin() //минимальная зп по отделам
        {
            Console.WriteLine("Введите номер отдела");
            double department = double.Parse(Console.ReadLine());
            var employeesInDepartment = employees.Where(e => e.Department == department);
            if (employeesInDepartment.Any())
            {
                var employeeWithMinSalary = employeesInDepartment.OrderBy(e => e.Salary).First();
                Console.WriteLine($"Человек с самой минимальной зарплатой в отделе {department}: {employeeWithMinSalary.Fio} - {employeeWithMinSalary.Salary} рублей");
            }
            else
            {
                Console.WriteLine($"Отдел {department} не найден или не имеет сотрудников.");
            }
        }
        void DepartamentSalaryMax() // максимальная зп по отделам
        {
            Console.WriteLine("Введите номер отдела"); double department = double.Parse(Console.ReadLine());
            var employeesInDepartment = employees.Where(e => e.Department == department); if (employeesInDepartment.Any())
            {
                var employeeWithMaxSalary = employeesInDepartment.OrderBy(e => e.Salary).Last();
                Console.WriteLine($"Человек с самой максимальной зарплатой в отделе {department}: {employeeWithMaxSalary.Fio} - {employeeWithMaxSalary.Salary} рублей");
            }
            else
            {
                Console.WriteLine($"Отдел {department} не найден или не имеет сотрудников.");
            }
        }
        void test9()//зп по отделу
            {
                Console.WriteLine("Введите число:");
                double expected_salary = double.Parse(Console.ReadLine());

                foreach (var emp in employees)
                {
                    if (emp.Salary < expected_salary)
                        Console.WriteLine($"Cотрудник под номером {emp._id} - {emp.Fio}, работающий в отделе " +
                            $"{emp.Department} получает зарплату в размере" +
                            $" {emp.Salary}");
                }
            }


            while (true)
            {
                Console.WriteLine("Напишите 0, чтобы узнать информацию о всех заданиях");

                int number_mission = Convert.ToInt32(Console.ReadLine()); // обзор по заданиям
                switch (number_mission)
                {
                    case 0:
                        Console.WriteLine("1-е задание: данные по всем сотрудникам");
                        Console.WriteLine("2-е задание: затраты на зп");
                        Console.WriteLine("3-е задание: сотрудник с самой маленькой зп");
                        Console.WriteLine("4-е задание: сотрудник с самой высокой зп");
                        Console.WriteLine("5-е задание: среднее зп ");
                        Console.WriteLine("6-е задание: ФИО всех сотрудников");
                        Console.WriteLine("7-е задание: индексация зп на фиксированный процент");
                        Console.WriteLine("8-е задание: Узнать зарплаты сотрудников в определённом отделе");
                        Console.WriteLine("9-е задание: Минимальная зп в определенном отделе");
                        Console.WriteLine("10-е задание: Максимальная зп в определенном отделе");

                    break;
                }

                int choice = Int32.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        EmployeeInfo();
                        break;
                    case 2:
                        EmployeeSalary();
                        break;
                    case 3:
                        MinSalary();
                        break;
                    case 4:
                        MaxSalary();
                        break;
                    case 5:
                        AvgSalary();
                        break;
                    case 6:
                        EmlployeeFio();
                        break;
                    case 7:
                        SalaryPrecent();
                        break;
                    case 8:
                        DepartmentEmployee();
                        break;
                    case 9:
                        DepartamentSalaryMin();
                        break;
                    case 10:
                    DepartamentSalaryMax();
                        break;

                }
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
