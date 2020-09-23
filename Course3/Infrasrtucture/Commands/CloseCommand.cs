﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Course3.Infrasrtucture.Commands
{
    class CloseCommand : Command
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            var x = parameter as Window;
            x.Close();
        }
    }
}
