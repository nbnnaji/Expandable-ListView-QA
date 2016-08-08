using System.Collections.Generic;
using Android.Content;
using Android.Views;
using Android.Widget;
namespace ExpListView
{
	public class Adapter: BaseExpandableListAdapter
	{
		public Context ctx;
		public Dictionary<string, List<string>> FAQsCategory;
		public List<string> FAQsList;


		public Adapter(Context ctx, Dictionary<string, List<string>> FAQsCategory, List<string> FAQsList)
		{
			this.ctx = ctx;
			this.FAQsCategory = FAQsCategory;
			this.FAQsList = FAQsList;

		}

		public override int GroupCount
		{
			get
			{
				return FAQsCategory.Count;
			}
		}

		public override bool HasStableIds
		{
			get
			{
				return false;
			}
		}

		public override Java.Lang.Object GetChild(int parent, int child)
		{
			return FAQsCategory[FAQsList[parent]][child];
		}

		public override long GetChildId(int parent, int child)
		{
			return child;
		}

		public override int GetChildrenCount(int groupPosition)
		{
			return FAQsCategory[FAQsList[groupPosition]].Count;
		}

		//returns a view for each sub-category
		public override View GetChildView(int parent, int child, bool lastChild, View convertView, ViewGroup parentView)
		{
			View newView = convertView;
			string child_title = (string)GetChild(parent, child);
			if (newView == null)
			{
				newView = LayoutInflater.From(ctx).Inflate(Resource.Layout.layout_answers, parentView, false);
			}
			TextView child_textView = newView.FindViewById<TextView>(Resource.Id.answers_txt);
			child_textView.Text = child_title;
			return newView;
		}

		public override Java.Lang.Object GetGroup(int groupPosition)
		{
			return FAQsList[groupPosition];
		}

		public override long GetGroupId(int groupPosition)
		{
			return groupPosition;
		}

		public override View GetGroupView(int parent, bool isExpanded, View convertView, ViewGroup parentGroup)
		{
			View newView = convertView;
			string parent_title = (string)GetGroup(parent);
			if (newView == null)
			{
				newView = LayoutInflater.From(ctx).Inflate(Resource.Layout.layout_questions, parentGroup, false);
			}
			TextView parent_textView = newView.FindViewById<TextView>(Resource.Id.questions_txt);
			parent_textView.SetTypeface(null, Android.Graphics.TypefaceStyle.Bold);
			parent_textView.Text = parent_title;
			return newView;
		}

		public override bool IsChildSelectable(int groupPosition, int childPosition)
		{
			return false;
		}
	}
}