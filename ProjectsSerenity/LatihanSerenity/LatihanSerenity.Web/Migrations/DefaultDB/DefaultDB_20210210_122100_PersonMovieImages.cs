using FluentMigrator;
using Serenity.Extensions;
using System;

namespace LatihanSerenity.Migrations.DefaultDB
{
    [Migration(20210210_122100)]
    public class DefaultDB_20210210_122100_PersonMovieImages : Migration
    {
        public override void Up()
        {
             Alter.Table("Person")
                .AddColumn("PrimaryImage").AsString(100).Nullable()
                .AddColumn("GalleryImages").AsString(int.MaxValue).Nullable();

            Alter.Table("Movie")
                .AddColumn("PrimaryImage").AsString(100).Nullable()
                .AddColumn("GalleryImages").AsString(int.MaxValue).Nullable();
        }


        public override void Down()
        {
        }
    }
}