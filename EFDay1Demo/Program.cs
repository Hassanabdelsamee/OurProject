using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDay1Demo
{
    internal class Program
    {
        //Linq To Sql XXXXXXXXX
        //EF  --> Database first , Code first 
        static void Main(string[] args)
        {
            //Company_SDEntities DbContext = new Company_SDEntities();
            //DbContext.Database.Log = Log  =>  Debug.WriteLine(Log);

            try
            {
                DBMRCodeneWV2Entities db = new DBMRCodeneWV2Entities();
                var x = DateTime.Now;
                var xc = db.checkcatogery(1);
              // var cs=xc.Select(c=>c.Student_ID).ToList();

                foreach(var c in xc)
                {
                    Console.WriteLine(c.);
                }

            }
            catch (Exception ex)

            {
                Console.WriteLine(ex.ToString());
            }

            //foreach(Department dep in DbContext.Departments)
            //{
            //    Console.WriteLine(dep.Dname);
            //}

            //var query = DbContext.Departments.Where(d => d.Dnum > 1);

            //foreach (Department department in query)
            //{
            //    Console.WriteLine(department.Dname);
            //}

            //var q1 = from emp in DbContext.Employees
            //         where emp.Salary>1000
            //         select emp;


            //string Input = "20";
            //int id = int.Parse(Input);
            //var q2 = from emp in DbContext.Employees.ToList()
            //             where emp.SSN >  int.Parse(Input)
            //             select emp;

            //foreach (Employee e in q2)
            //{
            //    Console.WriteLine(e.Fname);
            //}

            #region Insert

            //var dept = new Department()
            //{
            //    Dnum = 70, 
            //    Dname = "D70"
            //};
            //DbContext.Departments.Add(dept);
            //DbContext.SaveChanges();

            //var dept = new Department()
            //{
            //    Dnum = 80,
            //    Dname = "D80",
            //    Employees = new List<Employee>()
            //    {
            //        new Employee {SSN =8 , Fname ="Ali" , Bdate= DateTime.Now},
            //        new Employee {SSN =9 , Fname ="Ali2" , Bdate= DateTime.Now},
            //    }
            //};
            //DbContext.Departments.Add(dept);
            //DbContext.SaveChanges();

            // var emp = new Employee()
            // {
            //     SSN = 10,
            //     Fname = "Ahmed",
            //     Department = new Department() { Dnum = 90, Dname = "D90" }
            // };
            //DbContext.Employees.Add(emp);
            // DbContext.SaveChanges();



            #endregion


            #region Update
            //var dept = DbContext.Departments.Where(d => d.Dnum == 70).FirstOrDefault();
           
            //dept.Dname = "Front";

            // Console.WriteLine(DbContext.Entry(dept).State = System.Data.Entity.EntityState.);
            // DbContext.SaveChanges();
            #endregion


            #region Delete
            //var dept1 = DbContext.Departments.Where(d => d.Dnum == 70).FirstOrDefault();
            //DbContext.Departments.Remove(dept1);
            //DbContext.SaveChanges();
            #endregion


            //Company_SDEntities DbContext1 = new Company_SDEntities();
            //Company_SDEntities DbContext2 = new Company_SDEntities();

            //var emp1 = DbContext1.Employees.First();
            //emp1.Salary -= 2000;

            //var emp2 = DbContext2.Employees.First();
            //emp2.Salary -= 3000;

            //DbContext1.SaveChanges();

            //try
            //{
            //    DbContext2.SaveChanges();
            //}
            //catch(DbUpdateConcurrencyException ex)
            //{
            //    var entry = ex.Entries.First();
            //    entry.Reload();
            //    ((Employee)entry.Entity).Salary -= 3000;
            //   int x =  DbContext2.SaveChanges();

            //}
        








        }

    }
}
