using FluentMigrator;
using Serenity.Extensions;
using System;

namespace LatihanSerenity.Migrations.DefaultDB
{
    [Migration(20210208_090900)]
    public class DefaultDB_20210208_090900_MovieKind : Migration
    {
        public override void Up()
        {
            Alter.Table("Movie").InSchema("mov")
                .AddColumn("Kind").AsInt32().NotNullable()
                    .WithDefaultValue(1);
        }


        public override void Down()
        {
        }
    }
}