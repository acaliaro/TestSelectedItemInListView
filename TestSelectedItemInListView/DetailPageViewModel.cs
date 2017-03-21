using System;
namespace TestSelectedItemInListView.ViewModels
{
	[PropertyChanged.ImplementPropertyChanged]
	public class DetailPageViewModel
	{
		public string Title { get; set; }

		public DetailPageViewModel(string title) {
			this.Title = title;
		}
	}
}