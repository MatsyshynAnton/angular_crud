using System;

namespace BusinessLogicLayer.Exceptions
{
    public class NullEntityException:Exception
    {
        public NullEntityException(Type entityType) : base($"Entity {entityType} was null") { }
        public NullEntityException(string message) : base(message) { }
    }
}
