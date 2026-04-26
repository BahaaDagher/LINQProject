using LINQProject.Data;
using LINQProject.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace LINQProject
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ApplicationDbContext _context = new ApplicationDbContext();
            //var customers  =  _context.Customers.AsEnumerable();

            #region multible records
            //var customers  =  _context.Customers.AsQueryable();
            // filter 
            //customers = customers.Where(c=> c.State == "NY");
            //customers = customers.Where(c=> c.State == "NY"  && c.State == "TX");
            //customers = customers.Where(c=> c.State == "NY"  || c.State == "TX");
            //customers = customers.Where(c=> c.Phone ==  null );
            //customers = _context.Customers.Skip(10).Take(10) ;

            //foreach (var item in customers)
            //{
            //    Console.WriteLine($"{item.CustomerId} , {item.FirstName} , {item.Email}  , {item.State}");
            //} 
            #endregion

            #region Single Record
            //var customer = _context.Customers.Where(c=>c.State == "NY").First() ;
            //try { 
            //    var customer = _context.Customers.Where(c=>c.State == "GH").First() ;
            //    Console.WriteLine($"{customer.CustomerId} , {customer.FirstName} , {customer.Email}  , {customer.State}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //var customer = _context.Customers.Where(c => c.State == "GH").FirstOrDefault();
            //var customer = _context.Customers.Where(c => c.CustomerId == 1 ).SingleOrDefault();
            //var customer = _context.Customers.Where(c => c.State == "NY").OrderByDescending(c => c.CustomerId).FirstOrDefault();
            //var customer = _context.Customers.Where(c => c.State == "NY").OrderBy(c=>c.CustomerId).LastOrDefault();

            //var customer = _context.Customers.FirstOrDefault(c=>c.State == "NY");

            //if (customer != null)
            //     Console.WriteLine($"{customer.CustomerId} , {customer.FirstName} , {customer.Email}  , {customer.State}");

            #endregion
            //products = products.OrderByDescending(c=>c.ListPrice).ThenByDescending(); 

            #region Solve Challenge 1
            //var products =  _context.Products.AsQueryable();
            //products = products.OrderByDescending(p=>p.ListPrice); 
            //foreach (var item in products)
            //{
            //    Console.WriteLine($"{item.ProductId} , {item.ProductName}");
            //}

            //var product = _context.Products.Where(p => p.ProductId == 1).FirstOrDefault(); 
            //var product = _context.Products.FirstOrDefault(p => p.ProductId == 1); 
            //var product = _context.Products.SingleOrDefault(p => p.ProductId == 1); 
            //var product = _context.Products.OrderByDescending(p => p.ProductId).LastOrDefault(p => p.ProductId == 1); 
            //var product = _context.Products.OrderBy(p => p.ProductId).Skip(0).Take(1);
            //var product = _context.Products.Find(1);  
            #endregion

            #region Filter By Column 
            //var customers = _context.Customers.AsQueryable().Select(c => new
            //{
            //    c.CustomerId,
            //    c.FirstName,
            //    c.Email,
            //    c.State,
            //});

            //foreach (var item in customers)
            //{
            //    Console.WriteLine($"{item.CustomerId} , {item.FirstName} , {item.Email}  , {item.State}");
            //}
            #endregion

            #region Join
            //var OrdersWithCustomers = _context.Orders.Join(
            //        _context.Customers,
            //        o => o.CustomerId,
            //        c => c.CustomerId,
            //        (o, c) => new
            //        {
            //            o,
            //            c
            //        }
            //    ).Join(
            //        _context.Staffs,
            //        oc => oc.o.StaffId,
            //        s => s.StaffId,
            //        (oc, s) => new
            //        {
            //            oc.o.OrderId , 
            //            oc.o.OrderDate , 
            //            CustomerName  = oc.c.FirstName ,
            //            StaffName = s.FirstName , 
            //        }
            //    );
            //foreach(var item in OrdersWithCustomers)
            //{
            //    Console.WriteLine($"{item.OrderId} , {item.OrderDate} , {item.CustomerName} , {item.StaffName}");
            //}

            //var OrdersWithCustomers = _context.Orders.Include(o=>o.Customer).Select(o=> new
            //{
            //    o.OrderId  ,
            //    o.OrderDate , 
            //    o.Customer.FirstName , 
            //}) ;

            //var OrdersWithCustomers = _context.Orders.Select(o => new
            //{
            //    o.OrderId,
            //    o.OrderDate,
            //    o.Customer.FirstName,
            //});

            //foreach (var item in OrdersWithCustomers)
            //{
            //    Console.WriteLine($"{item.OrderId} , {item.OrderDate} , {item.FirstName} ");
            //}


            //var ProductsWithCategories =  _context.Products.Join(
            //        _context.Categories,
            //        p => p.CategoryId,
            //        c => c.CategoryId,
            //        (p, c) => new
            //        {
            //            p.ProductId,
            //            p.ProductName,
            //            c.CategoryName
            //        }
            //    );  
            #endregion

            #region solve challenge 2
            //var ProductsWithCategories = _context.Products.Include(c=>c.Category).Include(c=>c.Brand).Select(p=> new
            //{
            //    p.ProductId , 
            //    p.ProductName , 
            //    p.Category.CategoryName , 
            //    p.Brand.BrandName , 
            //});

            //foreach(var item in ProductsWithCategories )
            //{
            //    Console.WriteLine($"{item.ProductId} , {item.ProductName} , {item.CategoryName} , {item.BrandName}");
            //} 
            #endregion


            #region Group by
            //// group 

            //var CustomerGroups = _context.Customers.GroupBy(c=>c.State).Select(c=> new
            //{
            //    c.Key , 
            //    Count = c.Count()  , 
            //}); 
            //foreach(var item in CustomerGroups)
            //{
            //    Console.WriteLine($"{item.Key} , {item.Count}");
            //} 
            #endregion


            #region solve challenge 3
            // solve challenge 3 

            //var ProductGroups = _context.Products.GroupBy(p => p.ModelYear).Select(p => new
            //{
            //    p.Key,
            //    Sum = p.Sum(p => p.ListPrice)
            //});

            //foreach (var item in ProductGroups)
            //{
            //    Console.WriteLine($"{item.Key} , {item.Sum}");
            //}
            #endregion


            #region Create  , Update  , Delete
            //// create 
            //var categore = new Category()
            //{
            //    CategoryName = "Add new Category"
            //}; 
            //_context.Categories.Add(categore);

            //_context.SaveChanges();


            //var category = new Category()
            //{
            //    CategoryId = 2 ,
            //    CategoryName = "Updated Category" , 
            //};
            //_context.Categories.Update(category);


            //var category = _context.Categories.FirstOrDefault(c=>c.CategoryId == 3 );

            //category.CategoryName = "partial Category Update";

            //_context.SaveChanges();

            //var category = _context.Categories.FirstOrDefault(c => c.CategoryId == 3);

            //_context.Categories.Remove(category);
            //_context.SaveChanges(); 
            #endregion

            #region solve challenge 4 
            // solve challenge 4 

            //var customer = new Customer()
            //{
            //    FirstName = "Ahmed" , 
            //    LastName = "Ali" ,
            //    Email = "Ahmed.Ali@test.com"
            //};
            //_context.Customers.Add(customer);

            //_context.SaveChanges(); 

            //var staffs = _context.Staffs.AsQueryable(); 
            //foreach( var item in staffs)
            //{
            //    item.FirstName = "updatedStaffName"; 
            //}
            //_context.SaveChanges(); 
            #endregion



            #region Transaction
            //var transaction = _context.Database.BeginTransaction();

            //try {
            //    // insert 
            //    // update 
            //    // delete 
            //    // insert 
            //    transaction.Commit();

            //}
            //catch(Exception ex)
            //{
            //    transaction.Rollback(); 
            //} 
            #endregion

            #region Execute SP 
            string s = "inserted Category From C# ";
            _context.Database.ExecuteSqlRaw(
                $"execute usp_insert_category @name ",
                new SqlParameter("@name", s)
                );
            #endregion


            //List<int> ints = new List<int>();
            //ints.Add(1);
            //HashSet<int> ints = new HashSet<int>();
            //ints.Ad;

            string x = "abc";
            string result = x.RepeatString(3);
            Console.WriteLine(result);


            // this is a Comment 

        }

        
    }
    static class Helper
    {
        public static string RepeatString(this string s, int count)
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += s + " ";
            }
            return result;
        }
    }
}
