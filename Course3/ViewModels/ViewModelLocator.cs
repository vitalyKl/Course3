﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course3.ViewModels
{
    class ViewModelLocator
    {
        public SendWindowViewModel SendWindowModel => App.Services.GetRequiredService<SendWindowViewModel>();
    }
}