using System;
using PropertyChanged;
using Xamarin.Forms;

namespace TestSelectedItemInListView
{
	[ImplementPropertyChanged]
	public class MyModel
	{
		public string Name { get; set; }
		public string Surname { get; set; }

		public bool Selected { get; set; }

		public Color TextColor
		{
			get
			{
				if (Selected)
					return Color.Black;
				else
					return Color.Green;
			}
		}

		public MyModel()
		{
		}
	}
}
