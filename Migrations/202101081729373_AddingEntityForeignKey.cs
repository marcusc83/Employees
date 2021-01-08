namespace Employees.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingEntityForeignKey : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Departments", "MyEmployeesEmpId", c => c.Int(nullable: false));
            AlterColumn("dbo.Salaries", "MyEmployeesEmpId", c => c.Int(nullable: false));
            CreateIndex("dbo.Departments", "MyEmployeesEmpId");
            CreateIndex("dbo.Salaries", "MyEmployeesEmpId");
            AddForeignKey("dbo.Departments", "MyEmployeesEmpId", "dbo.MyEmployees", "empId");
            AddForeignKey("dbo.Salaries", "MyEmployeesEmpId", "dbo.MyEmployees", "empId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Salaries", "MyEmployeesEmpId", "dbo.MyEmployees");
            DropForeignKey("dbo.Departments", "MyEmployeesEmpId", "dbo.MyEmployees");
            DropIndex("dbo.Salaries", new[] { "MyEmployeesEmpId" });
            DropIndex("dbo.Departments", new[] { "MyEmployeesEmpId" });
        }
    }
}
