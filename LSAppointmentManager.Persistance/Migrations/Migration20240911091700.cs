using FluentMigrator;

namespace LSAppointmentManager.Persistance.Migrations
{
    [Migration(20240911091700, description: "First Creation of Database")]
    public class Migration20240911091700 : Migration
    {
        public override void Down()
        {
            Delete.Table("Workstation").IfExists();
            Delete.Table("Worker").IfExists();
            Delete.Table("ManagerUser").IfExists();
            Delete.Table("Customer").IfExists();
            Delete.Table("Sale").IfExists();
            Delete.Table("ProductService").IfExists();
            Delete.Table("ProductServiceDetail").IfExists();
            Delete.Table("Sale").IfExists();
            Delete.Table("SaleDetail").IfExists();
            Delete.Table("Appointment").IfExists();
        }

        public override void Up()
        {
            Create.Table("Workstation")
                   .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                   .WithColumn("Name").AsString().NotNullable()
                   .WithColumn("CreatedBy").AsString()
                   .WithColumn("CreatedDate").AsDateTime()
                   .WithColumn("ModifiedBy").AsString().Nullable()
                   .WithColumn("ModifiedDate").AsDateTime().Nullable();

            Create.Table("Worker")
                   .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                   .WithColumn("Name").AsString().NotNullable()
                   .WithColumn("Lastname").AsString().NotNullable()
                   .WithColumn("Lastname2").AsString().Nullable()
                   .WithColumn("Birthdate").AsDate().Nullable()
                   .WithColumn("Email").AsString().Nullable()
                   .WithColumn("PhoneNumber").AsString().Nullable()
                   .WithColumn("Gender").AsInt16().NotNullable()
                   .WithColumn("WorkstationId").AsInt32().ForeignKey("Workstation", "Id")
                   .WithColumn("CreatedBy").AsString()
                   .WithColumn("CreatedDate").AsDateTime()
                   .WithColumn("ModifiedBy").AsString().Nullable()
                   .WithColumn("ModifiedDate").AsDateTime().Nullable();

            Create.Table("ManagerUser")
                    .WithColumn("CreatedBy").AsString()
                    .WithColumn("CreatedDate").AsDateTime()
                    .WithColumn("ModifiedBy").AsString().Nullable()
                    .WithColumn("ModifiedDate").AsDateTime().Nullable()
                    .WithColumn("Username").AsString().PrimaryKey().NotNullable()
                    .WithColumn("Password").AsString().NotNullable()
                    .WithColumn("Name").AsString().NotNullable()
                    .WithColumn("Lastname").AsString().NotNullable()
                    .WithColumn("Lastname2").AsString().Nullable()
                    .WithColumn("Email").AsString().NotNullable()
                    .WithColumn("PhoneNumber").AsString().Nullable();

            Create.Table("Customer")
                    .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                    .WithColumn("Name").AsString().NotNullable()
                    .WithColumn("Lastname").AsString().NotNullable()
                    .WithColumn("Lastname2").AsString().Nullable()
                    .WithColumn("PhoneNumber").AsString().Nullable()
                    .WithColumn("Gender").AsInt32().NotNullable()
                    .WithColumn("Birthdate").AsDate().Nullable()
                    .WithColumn("CreatedBy").AsString().NotNullable()
                    .WithColumn("CreatedDate").AsDateTime().NotNullable()
                    .WithColumn("ModifiedBy").AsString().Nullable()
                    .WithColumn("ModifiedDate").AsDateTime().Nullable();

            Create.Table("Sale")
                   .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                   .WithColumn("CustomerId").AsInt32().ForeignKey("Customer", "Id")
                   .WithColumn("Subtotal").AsDecimal().NotNullable()
                   .WithColumn("Discount").AsDecimal().NotNullable()
                   .WithColumn("Taxes").AsDecimal().NotNullable()
                   .WithColumn("Total").AsDecimal().NotNullable()
                   .WithColumn("CreatedBy").AsString()
                   .WithColumn("CreatedDate").AsDateTime()
                   .WithColumn("ModifiedBy").AsString().Nullable()
                   .WithColumn("ModifiedDate").AsDateTime().Nullable();

            Create.Table("ProductService")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("Name").AsString().NotNullable()
                .WithColumn("Sku").AsString().NotNullable()
                .WithColumn("Description").AsString()
                .WithColumn("Price").AsDecimal()
                .WithColumn("HasTaxes").AsBoolean()
                .WithColumn("HasTaxesIncluded").AsBoolean()
                .WithColumn("CreatedBy").AsString()
                .WithColumn("CreatedDate").AsDateTime()
                .WithColumn("ModifiedBy").AsString().Nullable()
                .WithColumn("ModifiedDate").AsDateTime().Nullable();

            Create.Table("ProductServiceDetail")
               .WithColumn("Id").AsInt32().PrimaryKey().Identity()
               .WithColumn("ProductServiceId").AsInt32().NotNullable().ForeignKey("ProductService", "Id")
               .WithColumn("Name").AsString().NotNullable()
               .WithColumn("Sku").AsString().NotNullable()
               .WithColumn("Description").AsString()
               .WithColumn("Price").AsDecimal()
               .WithColumn("HasTaxes").AsBoolean()
               .WithColumn("HasTaxesIncluded").AsBoolean()
               .WithColumn("CreatedBy").AsString()
               .WithColumn("CreatedDate").AsDateTime()
               .WithColumn("ModifiedBy").AsString().Nullable()
               .WithColumn("ModifiedDate").AsDateTime().Nullable();

            Create.Table("SaleDetail")
               .WithColumn("Id").AsInt32().PrimaryKey().Identity()
               .WithColumn("SaleId").AsInt32().ForeignKey("Sale", "Id")
               .WithColumn("Quantity").AsDecimal().NotNullable()
               .WithColumn("Price").AsDecimal().NotNullable()
               .WithColumn("Discount").AsDecimal().NotNullable()
               .WithColumn("Taxes").AsDecimal().NotNullable()
               .WithColumn("Subtotal").AsDecimal().NotNullable()
               .WithColumn("Total").AsDecimal().NotNullable()
               .WithColumn("CreatedBy").AsString()
               .WithColumn("CreatedDate").AsDateTime()
               .WithColumn("ModifiedBy").AsString().Nullable()
               .WithColumn("ModifiedDate").AsDateTime().Nullable();

            Create.Table("Appointment")
                .WithColumn("Id").AsInt32().PrimaryKey().Identity()
                .WithColumn("Guid").AsGuid().Unique()
                .WithColumn("CustomerId").AsInt32().ForeignKey("Customer", "Id")
                .WithColumn("WorkerId").AsInt32().ForeignKey("Worker", "Id").Nullable()
                .WithColumn("AppointmentDate").AsDateTime()
                .WithColumn("IsCompleted").AsBoolean()
                .WithColumn("IsConfirmed").AsBoolean()
                .WithColumn("IsCancelled").AsBoolean()
                .WithColumn("CreatedBy").AsString()
                .WithColumn("CreatedDate").AsDateTime()
                .WithColumn("ModifiedBy").AsString().Nullable()
                .WithColumn("ModifiedDate").AsDateTime().Nullable();

        }
    }
}
