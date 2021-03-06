using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandbox;
using zs.ui;

namespace zs
{

	enum GameState
	{

		WaitForPlayers,
		GamePrepare,
		InGame,
		GameEnd,
		MapVote

	}

	[Library( "zs", Title = "Zombie Survival" )]
	partial class ZSGame : Game
    {

		[ServerVar]
		static public GameState gameState { get; private set; }

	    public ZSGame()
	    {

			gameState = GameState.WaitForPlayers;

			if ( IsServer )
			{
				new ZSHud();
			}

	    }

	    public override void ClientJoined( Client cl )
	    {

		    base.ClientJoined( cl );
		    var player = new ZSBaseController();
			player.Respawn();

			cl.Pawn = player;

	    }

	    public override void DoPlayerNoclip( Client player )
	    {
		    return;
	    }

    }
}
