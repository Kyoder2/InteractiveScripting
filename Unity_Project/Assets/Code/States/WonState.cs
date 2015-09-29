using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class WonState : IStateBase
	{Won
		private statemanager manager;

		public WonState(StateManager managerRef)  
		{
			manager = managerRef; //testing some stuff
			Debug.Log("Constructing WonState");
		}

		public void StateUpdate()
		{

		}

		public void ShowIt()
		{
			
		}
	}
}
