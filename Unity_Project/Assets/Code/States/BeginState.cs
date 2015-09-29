﻿using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class BeginState : IStateBase
	{
		private statemanager manager;

		public BeginState(StateManager managerRef)  
		{
			manager = managerRef; //testing some stuff
			Debug.Log("Constructing BeginState");
		}

		public void StateUpdate()
		{

		}

		public void ShowIt()
		{
			
		}
	}
}
