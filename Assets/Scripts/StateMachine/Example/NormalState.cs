using UnityEngine;

public class NormalState : StateMachineState<StateMachineOwner>
{
	public override void OnStateEnter(StateMachineOwner owner)
	{
		Debug.Log("I am now normal (Yeah right)");
	}

	public override void OnStateExit(StateMachineOwner owner)
	{
		Debug.Log("I am no longer normal");
	}

	public override void OnStateUpdate(StateMachineOwner owner)
	{

	}
}
