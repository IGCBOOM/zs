using Sandbox.UI;
using Sandbox.UI.Construct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zs.ui
{

	public class TestingPanel : Panel
	{

		public Label label;

		public TestingPanel()
		{

			label = Add.Label("test", "string");

		}

		public override void Tick()
		{

			label.Text = ZSGame.gameState.ToString();

			base.Tick();
		}

	}

}
