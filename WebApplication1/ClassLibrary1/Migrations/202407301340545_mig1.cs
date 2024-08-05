namespace ClassLibrary1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Headings", "WriterID", c => c.Int());
            CreateIndex("dbo.Headings", "WriterID");
            AddForeignKey("dbo.Headings", "WriterID", "dbo.Writers", "WriterID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Headings", "WriterID", "dbo.Writers");
            DropIndex("dbo.Headings", new[] { "WriterID" });
            DropColumn("dbo.Headings", "WriterID");
        }
    }
}
