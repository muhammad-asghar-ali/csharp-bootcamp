using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMS.Models;
using EMS.Data;

namespace EMS
{
    public class Program
    {
        static void Main(string[] args)
        {
            using var db = new AppDbContext();

            // insert data
            Manager manager = new();
            manager.FirstName = "John";
            manager.LastName = "Doe";

            db.Managers.Add(manager);
            db.SaveChanges();

            Employee emp = new();
            emp.FirstName = "Alex";
            emp.LastName = "John";
            emp.Salary = 1000;
            emp.ManagerId = 1;

            db.Employees.Add(emp);
            db.SaveChanges();

            // retrive data
            var employees = db.Employees.ToList();
            foreach (var ep in employees)
            {
                Console.WriteLine(ep.FirstName);
                Console.WriteLine(ep.Salary);
            }

            var employee = db.Employees.Single(e => e.Id == 1);
            Console.WriteLine("{0}, {1}, {2}", employee.FirstName, employee.LastName, employee.Salary);

            // update data
            var update = db.Employees.Single(e => e.Id == 1);
            Console.WriteLine("{0}, {1}, {2}", employee.FirstName, employee.LastName, employee.Salary);

            update.Salary = 80000;
            db.SaveChanges();
            Console.WriteLine("{0}, {1}, {2}", employee.FirstName, employee.LastName, employee.Salary);

            // delete data
            var mng = db.Managers.Single(m => m.Id == manager.Id);
            db.Managers.Remove(mng);
            db.SaveChanges();
        }
    }
}