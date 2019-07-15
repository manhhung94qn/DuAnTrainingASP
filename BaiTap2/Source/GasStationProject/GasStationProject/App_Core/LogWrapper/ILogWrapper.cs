using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStationProject.App_Core.LogWrapper
{
    public interface ILogWrapper
    {
        void Info(string message);
        void InfoFormat(string format, params object[] args);
        void Error(string message);
        void ErrorFormat(string format, params object[] args);
    }

}
