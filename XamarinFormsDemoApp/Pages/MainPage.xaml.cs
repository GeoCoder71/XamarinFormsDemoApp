using Xamarin.Forms;

namespace XamarinFormsDemoApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			BindingContext = new MainPageViewModel();
		}
	}
}
