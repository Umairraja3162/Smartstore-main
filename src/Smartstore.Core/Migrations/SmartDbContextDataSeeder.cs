﻿using Smartstore.Data.Migrations;

namespace Smartstore.Core.Data.Migrations
{
    public class SmartDbContextDataSeeder : IDataSeeder<SmartDbContext>
    {
        public bool RollbackOnFailure => false;

        public async Task SeedAsync(SmartDbContext context, CancellationToken cancelToken = default)
        {
            await context.MigrateLocaleResourcesAsync(MigrateLocaleResources);
            //await MigrateSettingsAsync(context, cancelToken);
        }

        //public async Task MigrateSettingsAsync(SmartDbContext db, CancellationToken cancelToken = default)
        //{

        //}

        public void MigrateLocaleResources(LocaleResourcesBuilder builder)
        {
            builder.Delete("Account.ChangePassword.Errors.PasswordIsNotProvided");

            builder.AddOrUpdate("Admin.Report.MediaFilesSize", "Media size", "Mediengröße");
        }
    }
}