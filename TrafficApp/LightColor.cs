using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficApp
{
    public enum LightColor
    {
        [Description("绿灯")]
        /// <summary>
        /// 绿灯
        /// </summary>
        Green = 10,
        [Description("黄灯")]
        /// <summary>
        /// 黄灯
        /// </summary>
        Yellow = 14,
        [Description("红灯")]
        /// <summary>
        /// 红灯
        /// </summary>
        Red = 12
    }
}
