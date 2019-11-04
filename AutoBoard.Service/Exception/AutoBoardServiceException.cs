using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBoard.Service
{
    /// <summary>
    /// AutoBoard Service Exception
    /// </summary>
    /// <seealso cref="System.ApplicationException" />
    [Serializable]
    public class AutoBoardServiceException : ApplicationException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoBoardServiceException"/> class.
        /// </summary>
        public AutoBoardServiceException() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoBoardServiceException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="ex">The ex.</param>
        public AutoBoardServiceException(string message, Exception ex) : base(message, ex)
        {
        }
    }
}
