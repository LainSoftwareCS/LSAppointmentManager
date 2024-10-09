using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSAppointmentManager.Repositories.Migrations
{
    [Migration(20241001162300, description: "Add description to appointment")]
    public class Migration20241001162300 : Migration
    {
        public override void Down()
        {
            Delete.Column("Description").FromTable("Appointment");
        }

        public override void Up()
        {
            Alter.Table("Appointment")
                .AddColumn("Description").AsString();
        }
    }
}
