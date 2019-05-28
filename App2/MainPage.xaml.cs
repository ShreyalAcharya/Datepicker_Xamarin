using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace App2
{
    public partial class MainPage : ContentPage
    {
        public string Format { get; set; }
        public DateTime? SelectedDate;

        
        public Color ResetColor
        {
            set => LblReset.TextColor = value;
        }

        public MainPage()
        {
            InitializeComponent();
        }

        private void Text_OnFocused(object sender, FocusEventArgs e)
        {
            TextEntry.Unfocus();
            Date.Focus();
        }

        private void Date_OnDateSelected(object sender, DateChangedEventArgs e)
        {
            SelectedDate = e.NewDate;
            //TextEntry.Text = String.IsNullOrEmpty(Format) ? e.NewDate.ToString(Format) : e.NewDate.ToString();
            TextEntry.Text = String.IsNullOrEmpty(Format) ? Convert.ToDateTime(e.NewDate).ToShortDateString() : Convert.ToDateTime(e.NewDate).ToShortDateString();
        }

        private void Reset_OnTapped(object sender, EventArgs e)
        {
            SelectedDate = null;
            TextEntry.Text = String.Empty;
        }
    }
}
