using System;
using System.ComponentModel;

namespace TestSelectedItemInListView.ViewModels
{
	public class DetailPageViewModel : INotifyPropertyChanged
	{
		public string Title { get; set; }

		public DetailPageViewModel(string title) {
			this.Title = title;
		}

        public event PropertyChangedEventHandler PropertyChanged;
    }
}