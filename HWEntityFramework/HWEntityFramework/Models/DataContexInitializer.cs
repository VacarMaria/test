using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HWEntityFramework.Models
{
    public class DataContexInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {

        protected override void Seed(ApplicationDbContext context)
        {
            context.Products.Add(new Product() { Id = 1, Name = "Tricou", Quantity = 10, Price = 123 });
            context.Products.Add(new Product() { Id = 2, Name = "Camasa", Quantity = 3, Price = 45 });

            context.Customers.Add(new Customer() { Id = 1, Name = "Cristina", Email = "cristina@yahoo.com", CreditCardNumber = 867574 });
            context.Customers.Add(new Customer() { Id = 2, Name = "Adrian", Email = "adrian@yahoo.com", CreditCardNumber = 657383 });

            context.StoreLocations.Add(new StoreLocation() { Id = 1, LocationName = "Brasov" });
            context.StoreLocations.Add(new StoreLocation() { Id = 2, LocationName = "Cluj" });

            context.SaveChanges();

            context.Sales.Add(
                new Sale() {
                    ProductID = context.Products.FirstOrDefault().Id,
                    CustomerId = context.Customers.FirstOrDefault().Id,
                    StoreLocationId = context.StoreLocations.FirstOrDefault().Id,
                    Date =DateTime.Now });

            context.SaveChanges();
        
            base.Seed(context);
        }
    }
}