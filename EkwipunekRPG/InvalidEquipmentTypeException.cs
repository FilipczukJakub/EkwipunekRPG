using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EkwipunekRPG
{
    public class InvalidEquipmentTypeException : Exception
    {
        public InvalidEquipmentTypeException()
        {
        }

        public InvalidEquipmentTypeException(string? message) : base(message)
        {
        }

        public InvalidEquipmentTypeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidEquipmentTypeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
