using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PZ
{
    class FormException : Exception
    {
           public FormException(string message) :base(message){ }

    }
}
