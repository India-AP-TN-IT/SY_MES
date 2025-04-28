using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY_MES.FX.Devices.Base
{
    public interface IDevice
    {
        string DeviceName { get; set; }
        bool OpenDevice(Dictionary<string, object> param);
        bool IsConnected();
        bool CloseDevice();
    }
}
