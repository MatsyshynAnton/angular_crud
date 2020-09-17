using System;

namespace BusinessLogicLayer.Exceptions
{
    public class NotFoundException:Exception
    {
        public NotFoundException(Type notFoundType, int entityId) : base($"Entity {notFoundType} with id {entityId} does not exist") { }

        public NotFoundException(string message) : base(message) { }
    }
}
