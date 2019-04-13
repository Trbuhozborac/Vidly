namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5d4573ea-d1a6-4932-9e5b-9ef18a46e34a', N'admin@vidly.com', 0, N'AGB2ByrnKze2XjUnP3lYdgsLvP/Wh+m6VTtPpdhdeQDnL0yfYkKT07D0xoVkl6PeiA==', N'2f73da2d-bc7e-4ffb-9278-625c52e87a21', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b5c341ed-547a-4f49-ba53-0761c91e293d', N'guest@vidly.com', 0, N'AMu66n7wNBfJsNGMS8DtvsAnHBbgJf4Yno8wxHhbhNBhGSqpyqLgi4FPQpytn8Md6g==', N'c538a16b-7987-4116-b0ca-f4ec89fc0ddf', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'12716916-69c1-4582-bd9e-536c377b3e58', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5d4573ea-d1a6-4932-9e5b-9ef18a46e34a', N'12716916-69c1-4582-bd9e-536c377b3e58')
                
            ");
        }
        
        public override void Down()
        {
        }
    }
}
