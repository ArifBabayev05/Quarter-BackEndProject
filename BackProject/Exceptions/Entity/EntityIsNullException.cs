using System;
namespace Exceptions.Entity
{
    public class EntityIsNullException : Exception
    {
        private static string _message = "Entity not found!";
        public EntityIsNullException() : base(_message)
        {

        }
    }
}

