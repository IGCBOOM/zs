using Sandbox;
using Sandbox.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zs.ui
{
	class ZSHud : HudEntity<RootPanel>
	{

		public ZSHud()
		{

			if ( !IsClient )
				return;

			RootPanel.StyleSheet.Load( "/ui/ZSHud.scss" );

			RootPanel.AddChild<TestingPanel>();

		}

	}
}
