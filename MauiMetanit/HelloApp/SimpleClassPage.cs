﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    internal class SimpleClassPage: ContentPage
    {
        public SimpleClassPage()
        {
            Content = new Label { Text = "Hello World!" };
        }
    }
}
