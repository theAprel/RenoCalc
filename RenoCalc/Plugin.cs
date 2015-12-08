using System;
using System.Windows.Controls;

using Hearthstone_Deck_Tracker.Plugins;

namespace RenoCalc
{
    public class Plugin : IPlugin
    {
		public string Author
		{
			get { return "Aprel"; }
		}

		public string ButtonText
		{
			get { return "RenoCalc"; }
		}

		public string Description
		{
			get { return "Displays a simple window UI with probabilites associated with Reno Jackson's battlecry activation."; }
		}

		public MenuItem MenuItem
		{
			get { return null; }
		}

		public string Name
		{
			get { return "RenoCalc"; }
		}

		public void OnButtonPress()
		{
		}

		public void OnLoad()
		{
            Calculator.Load();
		}

		public void OnUnload()
		{
		}

		public void OnUpdate()
		{
		}

		public Version Version
		{
			get { return new Version(0, 0, 1); }
		}
    }
}
