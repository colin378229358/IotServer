using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.Provider.Model
{
    public class CartStatus
    {
        #region 小车类型
        private int _carType = 0;            
        public int CarType
        {
            get { return _carType; }
            set { _carType = value; }
        }
        #endregion

        #region 小车编号
        private string _carNo = "";
        public string CarNo
        {
            get { return _carNo; }
            set { _carNo = value; }
        }
        #endregion

        #region 小车名称
        private string _carName = "";
        public string CarName
        {
            get { return _carName; }
            set { _carName = value; }
        }
        #endregion


    }
}
