using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RentalManagement.Models.DB
{
    public partial class GSQ2_Kiranjeet_DADContext : DbContext
    {
        public GSQ2_Kiranjeet_DADContext()
        {
        }

        public GSQ2_Kiranjeet_DADContext(DbContextOptions<GSQ2_Kiranjeet_DADContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<TruckData> TruckData { get; set; }
        public virtual DbSet<MonthlySalesRecord> MonthlySalesRecord { get; set; }
        public virtual DbSet<CarFeature> CarFeature { get; set; }
        public virtual DbSet<CarFeatures> CarFeatures { get; set; }
        public virtual DbSet<CarModel> CarModel { get; set; }
        public virtual DbSet<CarSaleRecord> CarSaleRecord { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerT> CustomerT { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<IndividualTruck> IndividualTruck { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<TruckCustomer> TruckCustomer { get; set; }
        public virtual DbSet<TruckEmployee> TruckEmployee { get; set; }
        public virtual DbSet<TruckFeature> TruckFeature { get; set; }
        public virtual DbSet<TruckFeatureAssociation> TruckFeatureAssociation { get; set; }
        public virtual DbSet<TruckModel> TruckModel { get; set; }
        public virtual DbSet<TruckPerson> TruckPerson { get; set; }
        public virtual DbSet<TruckRental> TruckRental { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=citadel.manukautech.info,6302;Initial Catalog=GSQ2_Kiranjeet_DAD;Persist Security Info=True;User ID=GSQ2_Kiranjeet;Password=fBit$56003;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Car>(entity =>
            {
                entity.Property(e => e.CarId).HasColumnName("CarID");

                entity.Property(e => e.BodyType)
                    .IsRequired()
                    .HasColumnName("Body_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CarModelId).HasColumnName("Car_Model_ID");

                entity.Property(e => e.Colour)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentMileage)
                    .IsRequired()
                    .HasColumnName("Current_Mileage")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DateImported)
                    .HasColumnName("Date_Imported")
                    .HasColumnType("date");

                entity.Property(e => e.ManufacturerYear).HasColumnName("Manufacturer_Year");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Transmission)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CarModel)
                    .WithMany(p => p.Car)
                    .HasForeignKey(d => d.CarModelId)
                    .HasConstraintName("FK_Car_CarModel");
            });

            modelBuilder.Entity<CarFeature>(entity =>
            {
                entity.ToTable("Car_Feature");

                entity.Property(e => e.CarFeatureId).HasColumnName("Car_Feature_ID");

                entity.Property(e => e.Feature)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CarFeatures>(entity =>
            {
                entity.HasKey(e => new { e.CarId, e.CarFeatureId });

                entity.Property(e => e.CarId).HasColumnName("Car_ID");

                entity.Property(e => e.CarFeatureId).HasColumnName("Car_Feature_ID");

                entity.HasOne(d => d.CarFeature)
                    .WithMany(p => p.CarFeatures)
                    .HasForeignKey(d => d.CarFeatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarFeatures_Car_Feature");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.CarFeatures)
                    .HasForeignKey(d => d.CarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarFeatures_Car");
            });

            modelBuilder.Entity<CarModel>(entity =>
            {
                entity.HasKey(e => e.ModelId);

                entity.Property(e => e.ModelId).HasColumnName("ModelID");

                entity.Property(e => e.EngineSize)
                    .IsRequired()
                    .HasColumnName("Engine_Size")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CarSaleRecord>(entity =>
            {
                entity.HasKey(e => e.SaleRecordId);

                entity.ToTable("Car_Sale_Record");

                entity.Property(e => e.SaleRecordId).HasColumnName("Sale_Record_ID");

                entity.Property(e => e.CarId).HasColumnName("CarID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Note)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.PuchaseDate)
                    .HasColumnName("Puchase_Date")
                    .HasColumnType("date");

                entity.Property(e => e.TotalPaidPrice)
                    .HasColumnName("Total_Paid_Price")
                    .HasColumnType("money");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.CarSaleRecord)
                    .HasForeignKey(d => d.CarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Car_Sale_Record_Car");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CarSaleRecord)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Car_Sale_Record_Customer");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .ValueGeneratedNever();

                entity.Property(e => e.LicenceExpiryDate)
                    .HasColumnName("Licence_Expiry_Date")
                    .HasColumnType("date");

                entity.Property(e => e.LicenceNumber)
                    .IsRequired()
                    .HasColumnName("Licence_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CustomerNavigation)
                    .WithOne(p => p.Customer)
                    .HasForeignKey<Customer>(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_Person");
            });

            modelBuilder.Entity<CustomerT>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.OfficeAddress)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneExtension)
                    .IsRequired()
                    .HasColumnName("Phone_Extension")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.EmployeeNavigation)
                    .WithOne(p => p.Employee)
                    .HasForeignKey<Employee>(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_Person");
            });

            modelBuilder.Entity<IndividualTruck>(entity =>
            {
                entity.HasKey(e => e.TruckId);

                entity.Property(e => e.TruckId).HasColumnName("TruckID");

                entity.Property(e => e.AdvanceDepositRequired).HasColumnType("money");

                entity.Property(e => e.Colour)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DailyRentalPrice).HasColumnType("money");

                entity.Property(e => e.DateImported).HasColumnType("date");

                entity.Property(e => e.FuelType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationExpiryDate).HasColumnType("date");

                entity.Property(e => e.RegistrationNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Transmission)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TruckModelId).HasColumnName("TruckModelID");

                entity.Property(e => e.WofexpiryDate)
                    .HasColumnName("WOFExpiryDate")
                    .HasColumnType("date");

                entity.HasOne(d => d.TruckModel)
                    .WithMany(p => p.IndividualTruck)
                    .HasForeignKey(d => d.TruckModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IndividualTruck_TruckModel");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("numeric(10, 3)");

                entity.Property(e => e.StockMaxLimit).HasColumnName("Stock_Max_Limit");

                entity.Property(e => e.StockMinLimit).HasColumnName("Stock_Min_Limit");
            });

            modelBuilder.Entity<TruckCustomer>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .ValueGeneratedNever();

                entity.Property(e => e.LicenseExpiryDate).HasColumnType("date");

                entity.Property(e => e.LicenseNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithOne(p => p.TruckCustomer)
                    .HasForeignKey<TruckCustomer>(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TruckCustomer_TruckPerson");
            });

            modelBuilder.Entity<TruckEmployee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.OfficeAddress)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneExtensionNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithOne(p => p.TruckEmployee)
                    .HasForeignKey<TruckEmployee>(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TruckEmployee_TruckPerson");
            });

            modelBuilder.Entity<TruckFeature>(entity =>
            {
                entity.HasKey(e => e.FeatureId);

                entity.Property(e => e.FeatureId).HasColumnName("FeatureID");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TruckFeatureAssociation>(entity =>
            {
                entity.HasKey(e => new { e.TruckId, e.FeatureId });

                entity.ToTable("Truck_Feature_Association");

                entity.Property(e => e.TruckId).HasColumnName("TruckID");

                entity.Property(e => e.FeatureId).HasColumnName("FeatureID");

                entity.HasOne(d => d.Feature)
                    .WithMany(p => p.TruckFeatureAssociation)
                    .HasForeignKey(d => d.FeatureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Truck_Feature_Association_TruckFeature");

                entity.HasOne(d => d.Truck)
                    .WithMany(p => p.TruckFeatureAssociation)
                    .HasForeignKey(d => d.TruckId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Truck_Feature_Association_IndividualTruck");
            });

            modelBuilder.Entity<TruckModel>(entity =>
            {
                entity.HasKey(e => e.ModelId);

                entity.Property(e => e.ModelId).HasColumnName("ModelID");

                entity.Property(e => e.Manufacturer)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Size)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TruckPerson>(entity =>
            {
                entity.HasKey(e => e.PersonId);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TruckRental>(entity =>
            {
                entity.HasKey(e => e.RentalId);

                entity.Property(e => e.RentalId).HasColumnName("RentalID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.RentDate).HasColumnType("date");

                entity.Property(e => e.ReturnDate).HasColumnType("date");

                entity.Property(e => e.ReturnDueDate).HasColumnType("date");

                entity.Property(e => e.TotalPrice).HasColumnType("money");

                entity.Property(e => e.TruckId).HasColumnName("TruckID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TruckRental)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TruckRental_TruckCustomer");

                entity.HasOne(d => d.Truck)
                    .WithMany(p => p.TruckRental)
                    .HasForeignKey(d => d.TruckId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TruckRental_IndividualTruck");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.Property(e => e.FirstName)
                    .HasColumnName("First_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("Last_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasColumnName("User_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TruckData>(entity =>
            {
                entity.HasKey(e => e.TruckId);

                entity.Property(e => e.model).HasColumnName("Model");
                entity.Property(e => e.manufacturer).HasColumnName("Manufacturer");
                entity.Property(e => e.colour).HasColumnName("Colour");
                entity.Property(e => e.registrationNumber).HasColumnName("Registration_Number");
                entity.Property(e => e.DailyRentalPrice).HasColumnName("Daily_Rental_Price");

            });

            modelBuilder.Entity<MonthlySalesRecord>(entity =>
            {
                entity.HasKey(e => e.saleID);

                entity.Property(e => e.month).HasColumnName("Month");
                entity.Property(e => e.year).HasColumnName("Year");
                entity.Property(e => e.salesAmount).HasColumnName("sale_amount");
            });
        }
    }
}
