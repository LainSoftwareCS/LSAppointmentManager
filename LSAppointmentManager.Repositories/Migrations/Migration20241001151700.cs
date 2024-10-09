using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSAppointmentManager.Repositories.Migrations
{
    [Migration(20241001151700, description: "Add start and end date in appointment")]
    public class Migration20241001151700 : Migration
    {
        public override void Down()
        {
            Alter.Table("Appointment")
                .AlterColumn("AppointmentDate").AsDateTime();

            Delete.Column("StartDate").FromTable("Appointment");
            Delete.Column("EndDate").FromTable("Appointment");
        }

        public override void Up()
        {
            Alter.Table("Appointment")
                .AlterColumn("AppointmentDate").AsDate().NotNullable()
                .AddColumn("StartDate").AsDateTime().NotNullable()
                .AddColumn("EndDate").AsDateTime().NotNullable();
        }
    }
}
