namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'86dbedb5-033b-41ae-81f7-46378ed46150', N'guest@vidly.com', 0, N'ANvjsRD3onFvPNMO/ofDDuMvME1GDXkgIvPnXQohYDQi4GJdBJ4kyBj5tkcWmZ7U3Q==', N'2253568b-cfb3-4301-a5ea-37df9a3337dd', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'db1c4c87-e532-46fe-9ce2-cda14142d033', N'admin@vidly.com', 0, N'ABkMaRZta1PBqb2eRcJsvPJY/OBGutK8bak3oEANGRpXfmKbfOThQRciQX/Ex9JhmA==', N'72f11c86-1538-48b4-bb9d-dbd741137bf7', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'7e7a2901-c41b-4d7b-bbbd-3d03b1515159', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'db1c4c87-e532-46fe-9ce2-cda14142d033', N'7e7a2901-c41b-4d7b-bbbd-3d03b1515159')

");
        }
        
        public override void Down()
        {
        }
    }
}
