using Course3.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course3.ViewModels
{
    class SendWindowViewModel: ViewModel
    {
        private string _title = "Message sender";

        public string Title
        {
            get => _title;
            set => Set(ref _title, value);
        }
    }
}
