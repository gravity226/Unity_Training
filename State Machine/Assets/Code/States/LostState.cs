using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class LostState : IStateBase
	{
		private StateManager manager;

		public LostState (StateManager managerRef)
		{
			manager = managerRef;
			Debug.Log ("Contructing Lost State");
		}
		
		public void StateUpdate()
		{
			if (Input.GetKeyUp (KeyCode.Space)) {
				Application.LoadLevel("BeginningScene");
				manager.SwitchState (new BeginState(manager));
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

