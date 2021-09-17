using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netcore3_1api_template.Exceptions
{
    public class NullException : AppExceptionBase
    {
        public NullException(string objectTypeName)
        {
            ObjectTypeName = objectTypeName;
        }

        public override string Message => $"This object [{ ObjectTypeName }] value is null.";
    }
}