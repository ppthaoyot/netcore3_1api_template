using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netcore3_1api_template.Exceptions
{
    public class InvalidDateException : AppExceptionBase
    {
        public InvalidDateException(string objectTypeName, string keys)
        {
            ObjectTypeName = objectTypeName;
            Keys = keys;
        }

        public override string Message => $"Object [{ ObjectTypeName}] ({Keys}) date is not valid.";
    }
}