using System;
using System.Activities;
using System.Collections.Generic;

namespace JohnnyFoulds.Samples
{
	/// <summary>
	/// The base activity for all sample activities
	/// </summary>
	public abstract class BaseActivity : System.Activities.NativeActivity
	{
		public static IDictionary<string, object> Invoke(Activity workflow)
		{
			return WorkflowInvoker.Invoke(workflow);
		}
	}
}
