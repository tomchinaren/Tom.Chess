﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tom.ChineseChess.Enum
{
    public enum ReturnCode
    {
        /// <summary>
        /// 成功
        /// </summary>
        Success = 10000,

        /// <summary>
        /// 系统繁忙
        /// </summary>
        SYSTEM_ERROR = 20000,
        /// <summary>
        /// 未知错误
        /// </summary>
        Error = 20001,
    }
}
