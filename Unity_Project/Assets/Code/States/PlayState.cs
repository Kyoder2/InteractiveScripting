using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class PlayState : IStateBase
	{
		private statemanager manager;

		public PlayState(StateManager managerRef)  
		{
			manager = managerRef; //testing some stuff
			Debug.Log("Constructing PlayState");
		}

		public void StateUpdate()
		{

		}

		public void ShowIt()
		{
			
		}
	}
}
