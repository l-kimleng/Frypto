namespace Frypto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedCanManagerUser : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'889eb6e6-a692-4920-8447-1a8367fdfde9', N'user@frypto.com', 0, N'ANBAvt+EH5cgs3qvqu3OJbiCn3rJr6+zdhYHeS6+nsyRUI7ExdPEnUsUPBdFOWiOCg==', N'36d9976a-ebed-4a29-adb9-c57c024ea0ab', NULL, 0, 0, NULL, 0, 0, N'user@frypto.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e149de76-a435-4030-87f2-9269efa15527', N'admin@frypto.com', 0, N'AOBVTbu1URlJ5ZjhxXzJgAEYtMvvhDXLQ5QSSjcmfSblFIOU8sVCl4316tgqUcyuaQ==', N'120244dc-ca4a-436d-81e3-294ae63f14fa', NULL, 0, 0, NULL, 0, 0, N'admin@frypto.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'0526b68d-96bb-4d42-b6cc-5ab11917787a', N'CanManageUser')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e149de76-a435-4030-87f2-9269efa15527', N'0526b68d-96bb-4d42-b6cc-5ab11917787a')
            ");
        }
        
        public override void Down()
        {
            Sql(@"
                DELETE FROM [dbo].[AspNetUserRoles] WHERE [UserId] = N'e149de76-a435-4030-87f2-9269efa15527' 
                                                      AND [RoleId] = N'0526b68d-96bb-4d42-b6cc-5ab11917787a';

	            DELETE FROM [dbo].[AspNetUsers] WHERE [Id] IN (
	            N'889eb6e6-a692-4920-8447-1a8367fdfde9',
	            N'e149de76-a435-4030-87f2-9269efa15527');

	            DELETE FROM [dbo].[AspNetRoles] WHERE [Id] = N'0526b68d-96bb-4d42-b6cc-5ab11917787a';
            ");
        }
    }
}
