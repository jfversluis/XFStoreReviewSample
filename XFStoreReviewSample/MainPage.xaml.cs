using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.StoreReview;
using Xamarin.Forms;

namespace XFStoreReviewSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            CrossStoreReview.Current.RequestReview(false);
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            CrossStoreReview.Current.OpenStoreListing("21312");
        }
    }
}
