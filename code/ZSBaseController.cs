using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandbox;

namespace zs
{

	partial class ZSBaseController : Player
	{

		public PawnController Ctrl;
		public Camera Cam;
		public ICamera PrevCam;

		public override void Spawn()
		{

			PrevCam = new FirstPersonCamera();
			base.Spawn();

		}

		public override void Simulate( Client cl )
		{

			base.Simulate( cl );

			if ( Input.ActiveChild != null )
			{
				ActiveChild = Input.ActiveChild;
			}

			TickPlayerUse();
			SimulateActiveChild( cl, ActiveChild );


		}

		public override void Respawn()
		{

			Controller = new WalkController();
			Animator = new StandardPlayerAnimator();
			Camera = PrevCam;

			EnableAllCollisions = true;
			EnableDrawing = true;
			EnableHideInFirstPerson = true;
			EnableShadowInFirstPerson = true;

			base.Respawn();

		}

	}

}
