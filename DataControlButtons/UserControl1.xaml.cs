using System.Drawing;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace DataControlButtons
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public ICommand BtnAddCommand { get => BtnAdd.Command; set => BtnAdd.Command = value; }
        public ICommand BtnEditCommand { get => BtnEdit.Command; set => BtnEdit.Command = value; }
        public ICommand BtnDeleteCommand { get => BtnDelete.Command; set => BtnDelete.Command = value; }

        public Brush BackGround
        {            
            set
            {
                BtnAdd.Background = value;
                BtnDelete.Background = value;
                BtnEdit.Background = value;
            }
        }


        public UserControl1()
        {
            InitializeComponent();
        }
    }
}