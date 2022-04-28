using System;

/// <summary>
/// A state machine transition contains methods for evaluating a transition
/// </summary>
public class StateMachineTransition<T>
{
	private readonly StateMachineState<T> origin;
	private readonly StateMachineState<T> target;
	private readonly (Func<bool> function, bool conditionCheck)[] conditions;

	public StateMachineTransition(StateMachineState<T> originState, StateMachineState<T> targetState, params(Func<bool>, bool conditionMode)[] inputConditions)
	{
		origin = originState;
		target = targetState;
		conditions = inputConditions;
	}

	/// <summary>
	/// Evaluates the condition and checks if it is equal to the condition mode
	/// set by the transition.
	/// </summary>
	/// <returns></returns>
	public bool Evaluate()
	{
		for(int i=0; i<conditions.Length; i++)
		{
			if (conditions[i].function() != conditions[i].conditionCheck)
			{
				return false;
			}
		}

		return true;
	}

	/// <summary>
	/// The target state in this transition
	/// </summary>
	public StateMachineState<T> TargetState
	{
		get { return target; }
	}

	/// <summary>
	/// The origin state in this transition
	/// </summary>
	public StateMachineState<T> OriginState
	{
		get { return origin; }
	}
}
