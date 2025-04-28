using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY_MES.FX.Controls.Base
{
    public interface IYGrid : IYControls
    {
        void SetValue(object value, string colName = "Value");
        string GetColNM(string colBindNM);
        string GetColNM(int col);
        object GetCellValue(int row, string colBindNM);
        object GetCellValue(int row, int col);
        string GetColBindNM(int col);
    }
}
