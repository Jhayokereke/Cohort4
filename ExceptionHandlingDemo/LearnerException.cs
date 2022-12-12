using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    public class LearnerException : Exception
    {
        public LearnerException() : base("You are a learner. Aren't you?")
        {
        }

        public LearnerException(string? message) : base(message)
        {
        }
    }
}
