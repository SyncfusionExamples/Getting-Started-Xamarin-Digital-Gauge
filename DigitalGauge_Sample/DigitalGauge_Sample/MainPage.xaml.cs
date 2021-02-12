using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DigitalGauge_Sample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var characterCount = digitalGauge.Value.Length;
            digitalGauge.WidthRequest = ((characterCount + 1) * digitalGauge.CharacterWidth) + (characterCount * digitalGauge.CharacterSpacing);
        }
    }
}
