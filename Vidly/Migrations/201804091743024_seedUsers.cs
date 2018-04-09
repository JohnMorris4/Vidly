namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class seedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0afe9501-d946-4ef2-9728-746350109646', N'admin@vidley.com', 0, N'AKtztUyWBC+NNXXeRMZFoimqmSD0Gk47CKbW+Efy/5tYpShJzdxzqNyYeNliSVVagg==', N'e5dd251b-3f4e-46ff-9b35-66821e924ef8', NULL, 0, 0, NULL, 1, 0, N'admin@vidley.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bbd67c82-811a-4b38-8185-1770ca090624', N'guest@vidley.com', 0, N'AG+HG798qSF3gY+2N4E9CBJ+q6Yhh+MAUAQxO3PeprstBfF/ERjhbJGY5+qf7tXnZg==', N'82216f84-9fa0-4f14-aeee-1186d51c2fcc', NULL, 0, 0, NULL, 1, 0, N'guest@vidley.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6e4e66e3-2b28-47d8-9510-e5d1e9c1e49e', N'CanManageMovie')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0afe9501-d946-4ef2-9728-746350109646', N'6e4e66e3-2b28-47d8-9510-e5d1e9c1e49e')



");
        }

        public override void Down()
        {
        }
    }
}
