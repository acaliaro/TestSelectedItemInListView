using TestSelectedItemInListView.ViewModels;
using Xamarin.Forms;

namespace TestSelectedItemInListView
{
	public partial class MasterPage : ContentPage
	{
		public MasterPage()
		{
			InitializeComponent();
			this.BindingContext = new MasterPageViewModel();
		}

		protected override void OnAppearing()
		{
			MessagingCenter.Subscribe<MasterPageViewModel, string>(this, "Detail", (arg1, arg2) => {

				((MasterDetailPage)Application.Current.MainPage).Detail = new DetailPage(arg2);
				((MasterDetailPage)Application.Current.MainPage).IsPresented = false;
			});
			base.OnAppearing();
		}

		protected override void OnDisappearing()
		{
			MessagingCenter.Unsubscribe<MasterPageViewModel, string>(this, "Detail");
			base.OnDisappearing();
		}
	}
}
