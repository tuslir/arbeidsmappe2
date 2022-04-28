using UnityEngine;

public class DeadState : StateMachineState<StateMachineOwner>
{
	public override void OnStateEnter(StateMachineOwner owner)
	{
		Debug.Log("I am now dead, shit...");
	}

	public override void OnStateExit(StateMachineOwner owner)
	{
		Debug.Log("There is no escaping death you jesus wannabe");
	}

	public override void OnStateUpdate(StateMachineOwner owner)
	{

	}
}
