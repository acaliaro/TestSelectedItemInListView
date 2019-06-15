using System;
using System.ComponentModel;
using PropertyChanged;
using Xamarin.Forms;

namespace TestSelectedItemInListView
{
	public class MyModel : INotifyPropertyChanged
	{
		public string Name { get; set; }
		public string Surname { get; set; }

		public bool Selected { get; set; }

		public MyModel()
		{
		}

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
