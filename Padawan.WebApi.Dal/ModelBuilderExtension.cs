using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Padawan.WebApi.Domain.Models;
using System;

namespace Padawan.WebApi.Dal
{
    public static class ModelBuilderExtension
    {
        public static ModelBuilder GlobalConfiguration(this ModelBuilder builder)
        {
            foreach (IMutableEntityType entityType in builder.Model.GetEntityTypes())
            {
                foreach (IMutableProperty property in entityType.GetProperties())
                {
                    switch (property.Name)
                    {
                        case nameof(Entity.Update):
                            property.IsNullable = true;
                            break;
                        case nameof(Entity.CreationDate):
                            property.IsNullable = false;
                            property.SetDefaultValue(DateTime.Now);
                            break;
                        case nameof(Entity.IsDeleted):
                            property.IsNullable = false;
                            property.SetDefaultValue(false);
                            break;
                        default:
                            break;
                    }
                }
            }
            return builder;
        }
    }
}
