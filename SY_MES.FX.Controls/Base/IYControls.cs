using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY_MES.FX.Controls.Base
{
    public interface IYControls
    {

        string Key { get; set; }
        string Desc { get; set; }
        void SetValue(object val);
        object GetValue();
        void ClearValue();
        void RefreshCtl();
    }
}
