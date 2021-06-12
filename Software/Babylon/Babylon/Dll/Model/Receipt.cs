﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll.Model
{
    public class Receipt
    {
        public int ID { get; set; }
        public User User { get; set; }
        public User Employee { get; set; }
        public List<ReceiptItem> ReceiptItem { get; set; }
    }
}
