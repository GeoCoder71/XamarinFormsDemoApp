namespace XamarinFormsDemoApp
{
	public class MainPageViewModel
	{
		public MainPageViewModel()
		{
			WelcomeMessage = "Welcome from ViewModel";
		}

		private string _welcomeMessage;
		public string WelcomeMessage
		{
			get
			{
				return _welcomeMessage;
			}
			set 
			{
				_welcomeMessage = value;
			}
		}
	}
}
