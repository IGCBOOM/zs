using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandbox;

namespace zs
{
	[Library( "zs", Title = "Zombie Survival" )]
	partial class ZSGame : Game
    {

	    public ZSGame()
	    {

			

	    }

	    public override void DoPlayerNoclip( Client player )
	    {
		    return;
	    }

    }
}
