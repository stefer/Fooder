using System;

namespace Fooder.Domain.Models
{
    public class Recipe
    {
        public Recipe()
        {
            Id = Guid.NewGuid();
            Name = string.Empty;
        }

        public Recipe(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public static readonly Recipe None = new (Guid.Empty, "None");
    }
}
