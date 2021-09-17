using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netcore3_1api_template.Models
{
    public interface IId
    {
        public Guid Id { get; set; }
    }
}