using System;
using System.Collections.Generic;

namespace Chattle.Models
{
    public record Role : IIdentifiable
    {
        public Guid Id { get; internal init; } = Guid.NewGuid();
        public string Name { get; init; } = String.Empty;
        public Color Color { get; init; } = Color.Black;
        public Permission Permission { get; init; } = Permission.None;
        public Guid ServerId { get; internal init; } = Guid.Empty;
        public IList<Guid> Users { get; init; } = Array.Empty<Guid>();
        public DateTime CreationDate { get; internal init; } = DateTime.UtcNow;
    }
}