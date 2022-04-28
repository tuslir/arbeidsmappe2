using UnityEngine;

public class AngryState : StateMachineState<StateMachineOwner>
{
	public override void OnStateEnter(StateMachineOwner owner)
	{
		Debug.Log("I am Angry, Grr");
	}

	public override void OnStateExit(StateMachineOwner owner)
	{
		Debug.Log("I am no longer angry");
	}

	public override void OnStateUpdate(StateMachineOwner owner)
	{

	}
}
