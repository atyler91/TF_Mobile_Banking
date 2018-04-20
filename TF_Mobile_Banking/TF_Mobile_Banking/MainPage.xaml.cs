using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TF_Mobile_Banking
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
	{
		public MainPage()
		{
			 if (Globals.g_Balances)
            {
                var navigationPage = new NavigationPage(new Balances());
                navigationPage.Icon = "";
                navigationPage.Title = "Balances";

                Children.Add(navigationPage);
            }
            if (Globals.g_History)
            {
                var navigationPage = new NavigationPage(new History());
                navigationPage.Icon = "";
                navigationPage.Title = "History";

                Children.Add(navigationPage);
            }
            if (Globals.g_ChangeInfo)
            {
                var navigationPage = new NavigationPage(new ChangeInfo());
                navigationPage.Icon = "";
                navigationPage.Title = "Change Info";

                Children.Add(navigationPage);
            }
            if (Globals.g_LoanApp)
            {
                var navigationPage = new NavigationPage(new LoanApp());
                navigationPage.Icon = "";
                navigationPage.Title = "Loan App";

                Children.Add(navigationPage);
            }
            if (Globals.g_PendingTrans)
            {
                var navigationPage = new NavigationPage(new PendingTrans());
                navigationPage.Icon = "";
                navigationPage.Title = "Pending Trans";

                Children.Add(navigationPage);
            }
            if (Globals.g_Statements)
            {
                var navigationPage = new NavigationPage(new Statements());
                navigationPage.Icon = "";
                navigationPage.Title = "E-Statements";

                Children.Add(navigationPage);
            }
            if (Globals.g_StopChecks)
            {
                var navigationPage = new NavigationPage(new StopChecks());
                navigationPage.Icon = "";
                navigationPage.Title = "Stop Checks";

                Children.Add(navigationPage);
            }
            if (Globals.g_Transfers)
            {
                var navigationPage = new NavigationPage(new Transfers());
                navigationPage.Icon = "";
                navigationPage.Title = "Transfers";

                Children.Add(navigationPage);
            }
            if (Globals.g_Withdrawal)
            {
                var navigationPage = new NavigationPage(new Withdrawal());
                navigationPage.Icon = "";
                navigationPage.Title = "Withdrawal";

                Children.Add(navigationPage);
            }
        }
	}
}