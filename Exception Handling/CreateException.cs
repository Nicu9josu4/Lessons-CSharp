using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    public class PersonalException : Exception
    {
        public string Message;
        public PersonalException()
        {

        }
        public PersonalException(string Message) : base(Message.ToLower()) 
        {
            //Message = Message.ToLower().Trim();
        }
        public PersonalException(string Message, Exception inner) : base(Message, inner) { }
    }
}
