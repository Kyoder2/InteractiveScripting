using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class LostState : IStateBase
	{
		private statemanager manager;

		public LostState(StateManager managerRef)  
		{
			manager = managerRef; //testing some stuff
			Debug.Log("Constructing LostState");
		}

		public void StateUpdate()
		{

		}

		public void ShowIt()
		{
			
		}
	}
}
