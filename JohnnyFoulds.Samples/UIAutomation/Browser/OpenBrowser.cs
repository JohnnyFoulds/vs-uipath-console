using System;
using System.Activities;
using System.Activities.Statements;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UiCore = UiPath.Core.Activities;

namespace JohnnyFoulds.Samples.UIAutomation.Browser
{
	public class OpenBrowser : BaseActivity
	{
		private static NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

		protected override void Execute(NativeActivityContext context)
		{
			Logger.Info("Execution started");

			// create the browser activity
			Logger.Info("Opening Web Browser");
			UiCore.OpenBrowser browser = new UiCore.OpenBrowser() {
				BrowserType = UiPath.Core.BrowserType.IE,
				Url = "http://www.google.co.za"
			};
			Invoke(browser);

			// enter search text
			Logger.Info("Entering Search Text");
			var typeQuery = new UiCore.TypeInto { 
				Text = "Use the query string dummy!",
				SimulateType = true
			};
			typeQuery.Target.Selector = "<html title='Google' /><webctrl name ='q' tag ='INPUT' />";
			Invoke(typeQuery);

			// click the search button
			Logger.Info("Clicking search button");
			var clickSearch = new UiCore.Click { SimulateClick = true };
			clickSearch.Target.Selector = "<html title='Google' /><webctrl name='btnK' tag='INPUT' />";
			Invoke(clickSearch);
		}
	}
}
