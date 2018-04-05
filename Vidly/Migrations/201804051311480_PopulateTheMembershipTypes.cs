namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateTheMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("update MembershipTypes Set Name= 'Pay As You Go' where id= 1");
            Sql("update MembershipTypes Set Name= 'Monthly' where id= 2");
            Sql("update MembershipTypes Set Name= 'Quartly' where id= 3");
            Sql("update MembershipTypes Set Name= 'Yearly' where id= 4");
        }

        public override void Down()
        {
        }
    }
}
