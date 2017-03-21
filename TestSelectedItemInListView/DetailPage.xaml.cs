using System;
using System.Collections.Generic;

using Xamarin.Forms;
using TestSelectedItemInListView.ViewModels;

namespace TestSelectedItemInListView
{
	public partial class DetailPage : ContentPage
	{
		public DetailPage( string title)
		{
			InitializeComponent();

			this.BindingContext = new DetailPageViewModel(title);
		}
	}
}
