using System;
using System.Collections.ObjectModel;
using PropertyChanged;

namespace TestSelectedItemInListView.ViewModels
{
	[ImplementPropertyChanged]
	public class TestSelectedItemInListViewViewModel
	{
		MyModel _selectedItem { get; set; }
		public ObservableCollection<MyModel> List { get; set; } = new ObservableCollection<MyModel>();

		public TestSelectedItemInListViewViewModel() { 
		
			List.Add(new MyModel() {Name ="Alessandro", Surname = "Caliaro" });
			List.Add(new MyModel() { Name="Marco", Surname = "VanBasten"});
			List.Add(new MyModel() { Name="James", Surname ="Lebron"});
		}
	
		public MyModel SelectedItem
		{
			get { return _selectedItem; }
			set
			{
				if (_selectedItem != null)
					_selectedItem.Selected = false;

				_selectedItem = value;

				if (_selectedItem != null)
					_selectedItem.Selected = true;
			}
		}

	}

}