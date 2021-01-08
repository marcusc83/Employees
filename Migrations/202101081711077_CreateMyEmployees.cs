namespace Employees.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMyEmployees : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        department = c.String(),
                        MyEmployeesEmpId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MyEmployees",
                c => new
                    {
                        empId = c.Int(nullable: false, identity: true),
                        firstName = c.String(),
                        lastName = c.String(),
                        streetAddress = c.String(),
                        city = c.String(),
                        state = c.String(),
                        zipCode = c.String(),
                        phoneNumber = c.String(),
                        emailAddress = c.String(),
                    })
                .PrimaryKey(t => t.empId);
            
            CreateTable(
                "dbo.Salaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        salary = c.Double(nullable: false),
                        MyEmployeesEmpId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
           
            Sql(@"UPDATE dbo.Salaries SET MyEmployeesEmpId = 1
              where MyEmployeesEmpId IS NULL");
            Sql(@"UPDATE dbo.Departments SET MyEmployeesEmpId = 1
              where MyEmployeesEmpId IS NULL");
        }
        
        public override void Down()
        {
            DropTable("dbo.Salaries");
            DropTable("dbo.MyEmployees");
            DropTable("dbo.Departments");
        }
    }
}
