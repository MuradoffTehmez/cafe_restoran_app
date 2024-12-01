using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeRestoranApp.Entities.Utilities
{
    internal class Logger
    {
        /// <summary>
        /// Log səviyyələri.
        /// </summary>
        public enum LogLevel
        {
            Info,
            Warning,
            Error,
            Critical
        }

        /// <summary>
        /// Log məlumatını fayla yazır və konsola çıxarır.
        /// </summary>
        /// <param name="message">Log mesajı.</param>
        /// <param name="level">Log səviyyəsi.</param>
        /// <param name="ex">Xəta obyekti (opsional).</param>
    }
}
