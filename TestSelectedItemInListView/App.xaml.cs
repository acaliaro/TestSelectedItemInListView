using Xamarin.Forms;

namespace TestSelectedItemInListView
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MasterDetailPage md = new MasterDetailPage();

			md.Detail = new TestSelectedItemInListViewPage();
			md.Master = new TestSelectedItemInListViewPage();
			MainPage = md;
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
