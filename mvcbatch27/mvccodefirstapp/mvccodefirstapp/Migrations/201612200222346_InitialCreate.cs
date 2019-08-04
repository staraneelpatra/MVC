namespace mvccodefirstapp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.depts",
                c => new
                    {
                        deptno = c.Int(nullable: false),
                        dname = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.deptno);
            
            CreateTable(
                "dbo.emps",
                c => new
                    {
                        empno = c.Int(nullable: false),
                        ename = c.String(),
                        sal = c.Int(nullable: false),
                        deptno = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.empno)
                .ForeignKey("dbo.depts", t => t.deptno, cascadeDelete: true)
                .Index(t => t.deptno);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.emps", "deptno", "dbo.depts");
            DropIndex("dbo.emps", new[] { "deptno" });
            DropTable("dbo.emps");
            DropTable("dbo.depts");
        }
    }
}
