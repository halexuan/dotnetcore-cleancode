using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode.SOLID.DRY.Model
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            ShowList( new Employee[] {
                new Developer() {
                    Name = "Developer",
                    Salary = 1000.0,
                    GithubLink = "github_developer",
                    Experience = 2
                },
                new Manager() {
                    Name = "Manager",
                    Salary = 2000.0,
                    GithubLink = "github_manager",
                    Experience = 5
                }
            });
            Console.ReadKey();
        }

        static List<EmployeeData> ShowList(Employee[] employees)
        {
            List<EmployeeData> listData = new List<EmployeeData>();

            foreach (var employee in employees)
            {
                listData.Add(Render(
                    new string[] {
                        "" + employee.CalculateExpectedSalary(),
                        "" + employee.Experience,
                        "" + employee.GithubLink
                        }
                    ));
            }

            return listData;
        }

        static EmployeeData Render(string[] fields)
        {
            EmployeeData employeeData = new EmployeeData();
            string data = string.Empty;

            foreach(string field in fields)
            {
                data += " " + field;
            }

            employeeData.SetData(data);
            Console.WriteLine(data);

            return employeeData;
        }

    }
}
