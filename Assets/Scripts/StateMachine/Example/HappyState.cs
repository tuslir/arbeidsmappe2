using UnityEngine;

public class HappyState : StateMachineState<StateMachineOwner>
{
	public override void OnStateEnter(StateMachineOwner owner)
	{
		Debug.Log("I am now happy :)");
	}

	public override void OnStateExit(StateMachineOwner owner)
	{
		Debug.Log("I am no longer happy :(");
	}

	public override void OnStateUpdate(StateMachineOwner owner)
	{

	}
}
