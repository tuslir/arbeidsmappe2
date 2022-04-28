using System;
using System.Collections.Generic;
using UnityEngine;

public class FiniteStateMachine<T> : IFiniteStateMachine<T>
{
	protected T owner;
	protected StateMachineState<T> currentState;
	protected Dictionary<StateMachineState<T>, List<StateMachineTransition<T>>> table;
	protected List<StateMachineTransition<T>> globalTable;

	/// <summary>
	/// Constructs a new finite state machine
	/// </summary>
	/// <param name="newOwner"></param>
	public FiniteStateMachine(T newOwner)
	{
		owner = newOwner;
		table = new Dictionary<StateMachineState<T>, List<StateMachineTransition<T>>>();
		globalTable = new List<StateMachineTransition<T>>();
	}

	public void Start(StateMachineState<T> startingState)
	{
		currentState = startingState;
		currentState.OnStateEnter(owner);
	}

	public T GetOwner()
	{
		return owner;
	}

	/// <summary>
	/// Adds a new transition to the finite state machine.
	/// </summary>
	/// <param name="origin">The state this transition originates from. If set to default, the transition is treated like a global transition</param>
	/// <param name="target">The state this transitions travels to. If invalid, this transition is not added</param>
	/// <param name="conditions">The list of condition and condition mode pairs to add </param>
	public void AddTransition(StateMachineState<T> origin, StateMachineState<T> target, params (Func<bool> condition, bool conditionMode)[] conditions)
	{
		if (target == null || conditions == null)
		{
			Debug.LogWarning("Either the target state or the condition is null. This is not allowed. State not added");
			return;
		}

		if (origin == default)
		{
			StateMachineTransition<T> transition = new StateMachineTransition<T>(origin, target, conditions);
			if (!globalTable.Contains(transition))
			{
				globalTable.Add(transition);
			}
		}

		else
		{
			if (table.ContainsKey(origin))
			{
				StateMachineTransition<T> newTransition = new StateMachineTransition<T>(origin, target, conditions);
				if (!table[origin].Contains(newTransition))
				{
					table[origin].Add(newTransition);
				}
			}

			else
			{
				table.Add(origin, new List<StateMachineTransition<T>>());
				table[origin].Add(new StateMachineTransition<T>(origin, target, conditions));
			}
		}
	}

	/// <summary>
	/// Adds a global transition to the finite state machine
	/// </summary>
	/// <param name="targetState">The state this transition goes to</param>
	/// <param name="conditions">The function and condition mode pairs to be evaluated</param>
	public void AddGlobalTransition(StateMachineState<T> targetState, params (Func<bool> condition, bool conditionMode)[] conditions)
	{
		AddTransition(default, targetState, conditions);
	}

	/// <summary>
	/// Transitions to the state if conditions allow it. First calls the current state OnStateExit
	/// method and then calls the next state OnStateEnter. If the current state is invalid only the
	/// next state's OnStateEnter is called.
	/// </summary>
	/// <param name="state"></param>
	private void TransitionToState(StateMachineState<T> state)
	{
		if (currentState != null && state != null && currentState != state)
		{
			currentState.OnStateExit(owner);
			currentState = state;
			currentState.OnStateEnter(owner);
		}

		else if (currentState == null && state != null && currentState != state)
		{
			currentState = state;
			state.OnStateEnter(owner);
		}
	}

	/// <summary>
	/// Evaluates transitions. First checks the global transitions, then the regular transitions
	/// </summary>
	/// <param name="state">The current state</param>
	private void EvaluateTransitions(StateMachineState<T> state)
	{
		foreach (StateMachineTransition<T> transition in globalTable)
		{
			if (transition.Evaluate())
			{
				TransitionToState(transition.TargetState);
				return;
			}
		}

		if (!table.ContainsKey(state))
		{
			return;
		}

		foreach(StateMachineTransition<T> transition in table[state])
		{
			if (transition.Evaluate())
			{
				TransitionToState(transition.TargetState);
				return;
			}
		}
	}

	/// <summary>
	/// Updates the machine. An update consists of a series of steps:
	/// First, the machine will check the global transition table. If a global transition is found, the machine will transition 
	/// to this state.
	/// If no global states are found, the machine will check the regular transitions originating from the current state.
	/// If no regular transitions are found, the machine will update it's current state.
	/// </summary>
	public void Update()
	{
		EvaluateTransitions(currentState);
		currentState.OnStateUpdate(owner);
	}

	/// <summary>
	/// The current state of the finite state machine
	/// </summary>
	public StateMachineState<T> CurrentState
	{
		get { return currentState; }
	}
}
