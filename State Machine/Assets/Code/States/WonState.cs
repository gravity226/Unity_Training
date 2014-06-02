using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class WonState : IStateBase
	{
		private StateManager manager;

		public WonState (StateManager managerRef)
		{
			manager = managerRef;
			Debug.Log ("Contructing Won State");
		}
		
		public void StateUpdate()
		{
			if (Input.GetKeyUp (KeyCode.Space)) {
				manager.SwitchState (new PlayState(manager));
			}
		}
		
		public void ShowIt()
		{
			
		}
		
		public void StateFixedUpdate()
		{
			
		}
	}
}

