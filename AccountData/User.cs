﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ChessApp;

namespace AccountData
{
    public partial class User
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Wins { get; set; } = 0;
        public int Losses { get; set; } = 0;
        public bool SaveExist { get; set; } = false;
        public bool AggressiveOn { get; set; } = false;
        public int ThemeId { get; set; } = 1;
        public Theme Theme { get; set; }
    }
}
