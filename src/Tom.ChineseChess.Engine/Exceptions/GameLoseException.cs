﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tom.ChineseChess.Engine.Exceptions
{
    class GameLoseException : Exception
    {
        public GameLoseException(string message)
            :base(message)
        {

        }
    }
}
