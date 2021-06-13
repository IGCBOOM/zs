using Sandbox.UI;
using Sandbox.UI.Construct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zs.ui
{

	class TestingPanel : Panel
	{

		public Label label;

		public TestingPanel()
		{

			label = Add.Label("test", "string");

		}

	}

}
