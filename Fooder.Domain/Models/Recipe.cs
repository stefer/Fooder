using System;

namespace Fooder.Domain.Models
{
    public class Recipe
    {
        public Recipe(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public Guid Id { get; }
        public string Name { get; }

        public static readonly Recipe None = new (Guid.Empty, "None");
    }
}
