using UnityEngine;
using Assets.Code.Interfaces;

namespace Assets.Code.States
{
	public class BeginState : IStateBase
	{
		private StateManager manager;
		private float futureTime= 0;
		private int countDown = 0;
		private float screenDuration = 8;

		public BeginState(StateManager managerRef)  
		{
			manager = managerRef; //testing some stuff
			Debug.Log("Constructing BeginState");
			futureTime = screenDuration + Time.realtimeSinceStartup;
			Time.timeScale = 0;
		}

		public void StateUpdate()
		{
			float rightNow = Time.realtimeSinceStartup;
			countDown = (int) futureTime - (int)rightNow;

			if (Input.GetKeyUp (KeyCode.Space) || countDown <= 0)
			{
				Switch();
			}
		}

		public void ShowIt()
		{
			if(GUI.Button(new Rect(10,10,150,100), "Press to Play")){
				
				Switch();
			}			
			GUI.Box ( new Rect (Screen.width - 60,10,50,25), countDown.ToString());
		}	
		void Switch()
		{
			Time.timeScale = 1;
			manager.SwitchState ( new PlayState (manager));
		}
	}
}
