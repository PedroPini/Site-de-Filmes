namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1ea70f55-ab07-4678-949f-fc05c8f6bda1', N'guest@vidly.com', 0, N'APDLMosy53NEZU88HbSigqeOaBrHoicgUGF9b+TgOgEn2RZaEMg1M3vmk7nGk1JMVg==', N'ae6f2a68-94cb-4406-a836-8ee332c509e8', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f415ef80-3ab4-462d-924a-3db6107a3ac8', N'admin@vidly.com', 0, N'AP22jxRFYNSQ2tpBKKiFwwDW8tj/agL2ANSm798bISzSAXQPpYoTAANGTTtlisfgtQ==', N'32f25ccf-982c-4265-8b8a-563f3020584d', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (NULL, NULL)

                ");
        }
        
        public override void Down()
        {
        }
    }
}
