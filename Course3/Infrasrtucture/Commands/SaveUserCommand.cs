using Course3.Views;
using Encoder;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;

namespace Course3.Infrasrtucture.Commands
{
    class SaveUserCommand : Command
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter)
        {
            IMailData md = parameter as IMailData;
            if (md.IsSavePassword == true && md.SeviceName != null && md.ServiceLogin != null && md.ServicePassword != null)
            {
                UserWorker uw = new UserWorker();
                DataEncoder de = new DataEncoder(md.ServiceLogin, md.ServicePassword);
                uw.SaveUser(md.SeviceName, md.ServiceLogin, de.ProtectedPassword);
            }
            else
                md.IsSavePassword = false;
            
        }
    }
}
