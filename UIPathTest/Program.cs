using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;
using CoreActivities = UiPath.Core.Activities;

namespace UIPathTest
{

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Testing some UIPath stuff...");

			// open notepad
			Console.WriteLine("Opening Notepad");
			CoreActivities.StartProcess notepadProcess = new CoreActivities.StartProcess();
			notepadProcess.FileName = "notepad.exe";
			WorkflowInvoker.Invoke(notepadProcess);

			// type into notepad
			Console.WriteLine("Typing text in Notepad");
			CoreActivities.TypeInto typeNotepad = new CoreActivities.TypeInto();
			typeNotepad.SimulateType = true;
			typeNotepad.Target.Selector = "<wnd app='notepad.exe' cls='Notepad' title='Untitled - Notepad' /><wnd aaname='Text Editor' cls='Edit' /><ctrl name='Text Editor' role='editable text' />";
			typeNotepad.Text = "Check this out!!";
			WorkflowInvoker.Invoke(typeNotepad);

			// keep the console open
			System.Console.WriteLine("\n\nPress any key to exit...");
			System.Console.ReadKey();
		}
	}
}
