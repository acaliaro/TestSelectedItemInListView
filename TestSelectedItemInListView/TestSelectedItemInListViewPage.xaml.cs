using TestSelectedItemInListView.ViewModels;
using Xamarin.Forms;

namespace TestSelectedItemInListView
{
	public partial class TestSelectedItemInListViewPage : ContentPage
	{
		public TestSelectedItemInListViewPage()
		{
			InitializeComponent();
			this.BindingContext = new TestSelectedItemInListViewViewModel();
		}
	}
}
