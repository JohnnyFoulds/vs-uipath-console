using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohnnyFoulds.StartupApp
{
	/// <summary>
	/// 
	/// </summary>
	/// <webrefrence name="create workflows at run time WWF">https://stackoverflow.com/questions/6530311/create-workflows-at-run-time-wwf</webrefrence>
	class Program
	{
		static void Main(string[] args)
		{
			// test the open browser activity
			var browserSequence = new System.Activities.Statements.Sequence {
				Activities = {
					new JohnnyFoulds.Samples.UIAutomation.Browser.OpenBrowser()
				}
			};

			System.Activities.WorkflowInvoker.Invoke(browserSequence);

			// keep the console open
			System.Console.WriteLine("\n\nPress any key to exit...");
			System.Console.ReadKey();
		}
	}
}
