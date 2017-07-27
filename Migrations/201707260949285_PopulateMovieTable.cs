namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies(Name,ReleaseDate,DateAdded,Stock) VALUES('The Prestige', '01.01.2011','01.01.2011',10)");
            Sql("INSERT INTO Movies(Name,ReleaseDate,DateAdded,Stock) VALUES('The Shawshank Redemption', '01.01.2011','01.01.2011',10)");
            Sql("INSERT INTO Movies(Name,ReleaseDate,DateAdded,Stock) VALUES('Inception', '01.01.2011','01.01.2011',10)");
        }
        
        public override void Down()
        {
        }
    }
}
