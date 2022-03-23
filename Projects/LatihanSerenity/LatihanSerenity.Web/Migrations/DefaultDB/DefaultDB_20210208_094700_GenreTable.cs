using FluentMigrator;
using Serenity.Extensions;
using System;

namespace LatihanSerenity.Migrations.DefaultDB
{
    [Migration(20210208_094700)]
    public class DefaultDB_20210208_094700_GenreTable : Migration
    {
        public override void Up()
        {
             Create.Table("Genre")
                .WithColumn("GenreId").AsInt32().NotNullable()
                    .PrimaryKey().Identity()
                .WithColumn("Name").AsString(100).NotNullable();

            Alter.Table("Movie")
                .AddColumn("GenreId").AsInt32().Nullable()
                    .ForeignKey("FK_Movie_GenreId", "Genre", "GenreId");
        }


        public override void Down()
        {
        }
    }
}