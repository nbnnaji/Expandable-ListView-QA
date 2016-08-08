using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Widget;
namespace ExpListView
{
	[Activity(Label = "ExpListView", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		Dictionary<string, List<string>> FAQs_category;
		List<string> FAQs_list;
		ExpandableListView Exp_list;
		Adapter adapter;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			//Set view as the expandable list view layout
			SetContentView(Resource.Layout.Main);
			Exp_list = FindViewById<ExpandableListView>(Resource.Id.exp_list);
			//Invoke data souce
			FAQs_category = DataProvider.getInfo();
			FAQs_list = new List<string>(FAQs_category.Keys);
			adapter = new Adapter(this, FAQs_category, FAQs_list);
			Exp_list.SetAdapter(adapter);
		}
	}
}






