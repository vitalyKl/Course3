using System.Windows;

namespace Course3.Infrasrtucture.Commands
{
    class ShutDownCommand : Command
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter) => Application.Current.Shutdown();
    }
}
