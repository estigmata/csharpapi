using APItwo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APItwo.Context
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            base.Seed(context);

            var fieldsToFormOne = new List<Field>
            {
                new Field
                {
                    Name = "First name",
                    TypeField = "Text"
                },
                new Field
                {
                    Name = "Last name",
                    TypeField = "Text"
                },
                new Field
                {
                    Name = "Email",
                    TypeField = "Email"
                }
            };
            Form formOne = new Form
            {
                Name = "Form one",
                Fields = fieldsToFormOne
            };
            context.Forms.Add(formOne);
            context.SaveChanges();
        }
    }
}