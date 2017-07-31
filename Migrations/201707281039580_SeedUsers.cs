namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7c14dbee-471f-40e1-9f6d-4eecd774dba7', N'golam.raashed@gmail.com', 0, N'ANqRp5h/51fatNdVt6SoO4z+7GardQ/r9httdKz0W4PrK0VJv564PqwN1GaF86Ya9A==', N'ea71887a-c4b4-4ce0-b21d-724ab701c850', NULL, 0, 0, NULL, 1, 0, N'golam.raashed@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a1e907b8-eb15-4be5-ad6f-9ebaca85953b', N'admin@vidly.com', 0, N'ANqDaweVZUCZxV8Yq3RKhBpqHGP8ntmI/ctwPu4GrrYwodN+99G4+WfnjvVtCat17g==', N'ffa2e44f-ee47-4626-a0aa-a8baf30a25b8', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a5beef74-beda-4fb7-ba2b-c2ab3eb45292', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a1e907b8-eb15-4be5-ad6f-9ebaca85953b', N'a5beef74-beda-4fb7-ba2b-c2ab3eb45292')

");
        }

        public override void Down()
        {
        }
    }
}
