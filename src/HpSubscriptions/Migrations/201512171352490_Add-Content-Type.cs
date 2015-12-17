namespace HpSubscriptions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddContentType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SubscriptionRecords", "ContentType", builder => builder.String() );
            Sql("update SubscriptionRecords set ContentType = 'text/xml'");
        }
        
        public override void Down()
        {
            DropColumn("dbo.SubscriptionRecords", "ContentType");

        }
    }
}
