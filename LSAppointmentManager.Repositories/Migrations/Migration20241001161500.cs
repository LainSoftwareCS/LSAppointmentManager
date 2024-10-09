using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSAppointmentManager.Repositories.Migrations
{
    [Migration(20241001161500, description: "Add email customer")]
    public class Migration20241001161500 : Migration
    {
        public override void Down()
        {
            Delete.Column("Email").FromTable("Customer");
        }

        public override void Up()
        {
            Alter.Table("Customer")
                .AddColumn("Email").AsString();
        }
    }
}
