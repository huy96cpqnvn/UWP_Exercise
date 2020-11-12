using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Practice.Models
{
    public static class SeedData
    {
        public static void SeedEmployee(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                    new Employee
                    {
                        Name = "John",
                        Birthday = "20-10-1999",
                        Phone = "0123456789",
                        Address = "34 Tay Ho, Ha Noi"
                    },
                    new Employee
                    {
                        Name = "David",
                        Birthday = "23-1-1989",
                        Phone = "0123789456",
                        Address = "22 Hoan Kiem, Ha Noi"
                    },
                    new Employee
                    {
                        Name = "Anna",
                        Birthday = "2-10-1998",
                        Phone = "0123123123",
                        Address = "33 Nguyen Trai, Ha Noi"
                    },
                    new Employee
                    {
                        Name = "William",
                        Birthday = "2-9-1999",
                        Phone = "0132456987",
                        Address = "56 Hoan Kiem, Ha Noi"
                    },
                    new Employee
                    {
                        Name = "Mike",
                        Birthday = "21-10-1999",
                        Phone = "0122226789",
                        Address = "123 Tay Ho, Ha Noi"
                    },
                    new Employee
                    {
                        Name = "Lyly",
                        Birthday = "11-10-1994",
                        Phone = "0123453211",
                        Address = "33 Ton Duc Thang, Ha Noi"
                    },
                    new Employee
                    {
                        Name = "Nana",
                        Birthday = "20-8-1990",
                        Phone = "0123111789",
                        Address = "343 Giang Vo, Ha Noi"
                    },
                    new Employee
                    {
                        Name = "Michalle",
                        Birthday = "10-11-1999",
                        Phone = "0123336789",
                        Address = "34 Dong Da, Ha Noi"
                    },
                    new Employee
                    {
                        Name = "Lisa",
                        Birthday = "20-6-1988",
                        Phone = "0136996389",
                        Address = "34 Kim Ma, Ha Noi"
                    }
                );
                context.SaveChanges();
            }
        }
    
}
}
