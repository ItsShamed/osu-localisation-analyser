using System;

namespace LocalisationAnalyser.Generators
{
    public class LocalisationParameter : IEquatable<LocalisationParameter>
    {
        public readonly string Type;
        public readonly string Name;

        public LocalisationParameter(string type, string name)
        {
            Type = type;
            Name = name;
        }

        public bool Equals(LocalisationParameter? other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return Type == other.Type && Name == other.Name;
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;

            return Equals((LocalisationParameter)obj);
        }

        public override int GetHashCode() => HashCode.Combine(Type, Name);
    }
}