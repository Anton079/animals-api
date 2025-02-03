using FluentMigrator;
using Microsoft.AspNetCore.Http.HttpResults;

namespace animals_api.Data.Migrations
{
    [Migration(02022025)]
    public class CreateSchema : Migration
    {
        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            Create.Table("animal")
                .WithColumn("id").AsInt32().PrimaryKey().Identity()
                .WithColumn("type").AsString(120).NotNullable()
                .WithColumn("name").AsString(120).NotNullable()
                .WithColumn("age").AsInt32().NotNullable();
        }
    }
}
