using Xamarin.Forms;

namespace TestSelectedItemInListView
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MasterDetailPage md = new MasterDetailPage();

			md.Detail = new DetailPage("UNSELECTED");
			md.Master = new MasterPage();
			md.IsPresented = true;
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
