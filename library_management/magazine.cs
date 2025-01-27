﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_management
{
    public class magazine : LibraryItem
    {
        public int IssueNumber { get; set; }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Issue Number: {IssueNumber}");
        }
    }
}