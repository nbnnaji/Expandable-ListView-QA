using System.Collections.Generic;
namespace ExpListView
{
	public class DataProvider
	{
		public static Dictionary<string, List<string>> getInfo()
		{
			Dictionary<string, List<string>> AccountDetails = new Dictionary<string, List<string>>();
			List<string> ACCT_FAQs = new List<string>();
			ACCT_FAQs.Add("Call 909-220-2233.");

			List<string> ACCT_FAQs2 = new List<string>();
			ACCT_FAQs2.Add("Only checking account.");

			List<string> ACCT_FAQs3 = new List<string>();
			ACCT_FAQs3.Add("Yes you can.");

			List<string> ACCT_FAQs4 = new List<string>();
			ACCT_FAQs4.Add("Of course! Give us a call and we will set you up.");

			List<string> ACCT_FAQs5 = new List<string>();
			ACCT_FAQs5.Add("It is if you are reading this.");


			AccountDetails.Add("How do I open an account?", ACCT_FAQs);
			AccountDetails.Add("What type of account can I open?", ACCT_FAQs2);
			AccountDetails.Add("Can I open an account for a minor?", ACCT_FAQs3);
			AccountDetails.Add("Can I check my account from my phone?", ACCT_FAQs4);
			AccountDetails.Add("Is expandable listview important?", ACCT_FAQs5);

			return AccountDetails;
		}

	}
}