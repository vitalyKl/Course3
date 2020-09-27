using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Course3.Infrasrtucture.Commands
{
    class NextTabCommand : Command
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            if (parameter == null)
                return;
            TabControl x = parameter as TabControl;
            x.SelectedIndex++;
        }
    }
}
