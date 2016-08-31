using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EntryBindingTest
{
    public partial class Email : ContentPage
    {
        public Email()
        {
            InitializeComponent();
            this.BindingContext = new EmailViewModel();
        }
    }
}
