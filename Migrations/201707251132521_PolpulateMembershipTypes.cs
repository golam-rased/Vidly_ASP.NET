namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PolpulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee,DurationInMonths,DiscountRate) VALUES (1,0,0,0)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee,DurationInMonths,DiscountRate) VALUES (2,30,1,10)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee,DurationInMonths,DiscountRate) VALUES (3,60,3,20)");
            Sql("INSERT INTO MembershipTypes (Id, SignUpFee,DurationInMonths,DiscountRate) VALUES (4,90,12,30)");
        }
        
        public override void Down()
        {
        }
    }
}
