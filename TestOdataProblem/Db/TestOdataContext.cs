using Microsoft.EntityFrameworkCore;
using System;
using TestOdataProblem.Models;

namespace TestOdataProblem.Db
{
    public class TestOdataContext : DbContext
    {

        public TestOdataContext() { }
        //    public TestOdataContext(DbContextOptions<TestOdataContext> options)
        //: base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=.; database=TestOdataDb; user id=newLogin; password=123456");
            }
        }
        public virtual DbSet<Office> Offices { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Office>().HasData(new Office { Id = new Guid("3416C9E4-4C1C-4122-BF8A-8BB6428238F0"), ZipCode = "12401", AddressLine = "58 Fair St", City = "Kingston", Active = true });
            modelBuilder.Entity<Office>().HasData(new Office { Id = new Guid("3F22C7DD-4B17-403E-BBB5-4D8C30520CB7"), ZipCode = "77474", AddressLine = "426 Brazos Hill Ln", City = "Sealy", Active = true });
            modelBuilder.Entity<Office>().HasData(new Office { Id = new Guid("3498634E-B8AE-4C8E-B699-0FBAFC7D8729"), ZipCode = "08901", AddressLine = "78 College Ave", City = "New Brunswick", Active = true });
            modelBuilder.Entity<Office>().HasData(new Office { Id = new Guid("C21FA9A0-98F2-4453-AA1F-7906B7D297DD"), ZipCode = "30643", AddressLine = "178 Chandlers Ferry Rd", City = "Hartwell", Active = true });
            modelBuilder.Entity<Office>().HasData(new Office { Id = new Guid("D6A97B73-E935-41E4-88DF-9B735BCE29B5"), ZipCode = "39323", AddressLine = "110 Popular St", City = "Chunky", Active = true });
            modelBuilder.Entity<Office>().HasData(new Office { Id = new Guid("8A01633A-FDB0-44AB-BEE1-CA8CCB2ED0DE"), ZipCode = "08106", AddressLine = "111 Yale Rd", City = "Audubon", Active = true });
            modelBuilder.Entity<Office>().HasData(new Office { Id = new Guid("F36F5352-ED1D-495D-8B20-A8DDFACD792D"), ZipCode = "11756", AddressLine = "173 N Wantagh Ave", City = "Levittown", Active = true });
            modelBuilder.Entity<Office>().HasData(new Office { Id = new Guid("096904E4-BAB9-4F1A-B7F3-27524E9E658B"), ZipCode = "07701", AddressLine = "248 Leighton Ave", City = "Red Bank", Active = true });
            modelBuilder.Entity<Office>().HasData(new Office { Id = new Guid("4200B0AE-DE2B-4EBB-8A25-D8227431D921"), ZipCode = "94903", AddressLine = "837 Estancia Way", City = "San Rafael", Active = true });
            modelBuilder.Entity<Office>().HasData(new Office { Id = new Guid("1CC41EB5-7839-46E8-8EFA-B1CFD2721A62"), ZipCode = "27284", AddressLine = "42 Meadowbrook Park Dr", City = "Kernersville", Active = true });
            modelBuilder.Entity<Office>().HasData(new Office { Id = new Guid("0D1259C5-F06B-4E86-B7D0-5F56BFA5C70B"), ZipCode = "96720", AddressLine = "899  Randall Drive", City = "Hillo", Active = true });
            modelBuilder.Entity<Office>().HasData(new Office { Id = new Guid("75AE4ECB-50C0-44BB-ABD8-C6020ADA346C"), ZipCode = "66451", AddressLine = "303  Gerald L. Bates Drive", City = "LYNDON", Active = true });
            modelBuilder.Entity<Office>().HasData(new Office { Id = new Guid("3123333B-4AC5-4D1B-9047-7881D060DF68"), ZipCode = "12401", AddressLine = "18 Fair St", City = "Kingston", Active = true });
            modelBuilder.Entity<Office>().HasData(new Office { Id = new Guid("C563789F-AF45-4946-A2AB-46DAB5B7856D"), ZipCode = "12401", AddressLine = "3440  Indiana Avenue", City = "Kingston", Active = true });
            modelBuilder.Entity<Office>().HasData(new Office { Id = new Guid("691CC6F4-76AF-4DF6-99DC-34DFBC93AB6E"), ZipCode = "12401", AddressLine = "108 Fair St", City = "Kingston", Active = false });


            modelBuilder.Entity<Employee>().HasData(new Employee { Id = new Guid("26F5D47A-0088-4C4B-9BFB-A893CFDE68EA"), Name = "John Smith", OfficeId = new Guid("3416C9E4-4C1C-4122-BF8A-8BB6428238F0") });
            modelBuilder.Entity<Employee>().HasData(new Employee { Id = new Guid("5F324E14-542C-4A40-A4B8-8ACCA5C0DCE6"), Name = "John Doe", OfficeId = new Guid("3416C9E4-4C1C-4122-BF8A-8BB6428238F0") });
            modelBuilder.Entity<Employee>().HasData(new Employee { Id = new Guid("6D96CBD4-61B2-4786-B9C4-29191C61E41A"), Name = "Vic Down", OfficeId = new Guid("3416C9E4-4C1C-4122-BF8A-8BB6428238F0") });
            modelBuilder.Entity<Employee>().HasData(new Employee { Id = new Guid("EF90EF76-7751-41F2-9DFC-887C291BD2F9"), Name = "Amanda Tulip", OfficeId = new Guid("3F22C7DD-4B17-403E-BBB5-4D8C30520CB7") });
            modelBuilder.Entity<Employee>().HasData(new Employee { Id = new Guid("9B3592AE-AB5D-45D3-A153-F6D93A870C9C"), Name = "Jane S", OfficeId = new Guid("C21FA9A0-98F2-4453-AA1F-7906B7D297DD") });
            modelBuilder.Entity<Employee>().HasData(new Employee { Id = new Guid("AECFA712-1D14-45EF-8150-9DB3CE550C4E"), Name = "James Green", OfficeId = new Guid("C21FA9A0-98F2-4453-AA1F-7906B7D297DD") });

            modelBuilder.Entity<Employee>().HasData(new Employee { Id = new Guid("DF4FE7A8-C754-473A-AAF1-13EBCBF8BE90"), Name = "Ben Foss", OfficeId = new Guid("3498634E-B8AE-4C8E-B699-0FBAFC7D8729") });

            modelBuilder.Entity<Employee>().HasData(new Employee { Id = new Guid("7925C62D-1B8D-4009-8559-15E9ED43B46A"), Name = "Milton P Smith", OfficeId = new Guid("8A01633A-FDB0-44AB-BEE1-CA8CCB2ED0DE") });
            modelBuilder.Entity<Employee>().HasData(new Employee { Id = new Guid("803FC464-1ECB-40F2-B3A4-54396F5C38BA"), Name = "Dewey K Smith", OfficeId = new Guid("8A01633A-FDB0-44AB-BEE1-CA8CCB2ED0DE") });
            modelBuilder.Entity<Employee>().HasData(new Employee { Id = new Guid("B75E73EF-BAC5-475B-9F06-CBF82E8F344C"), Name = "Harrison F Johnson", OfficeId = new Guid("096904E4-BAB9-4F1A-B7F3-27524E9E658B") });
            modelBuilder.Entity<Employee>().HasData(new Employee { Id = new Guid("2682660B-E6F7-452D-8677-C70C75D6C13D"), Name = "Brian K Johnson", OfficeId = new Guid("096904E4-BAB9-4F1A-B7F3-27524E9E658B") });
            modelBuilder.Entity<Employee>().HasData(new Employee { Id = new Guid("7036FAB9-6196-4B14-BE8F-39012BE8109D"), Name = "Amber Smith", OfficeId = new Guid("4200B0AE-DE2B-4EBB-8A25-D8227431D921") });
        }
    }
}
