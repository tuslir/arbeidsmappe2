/// <summary>
/// Base class for a state machine state. 
/// </summary>
/// <typeparam name="T">The owner of the state</typeparam>
public abstract class StateMachineState<T>
{
	/// <summary>
	/// This method is called when the state machine enters the state. Note, this method is called in the same frame
	/// as the previous state's OnStateExit.
	/// </summary>
	/// <param name="owner">The owner of the state machine</param>
	public abstract void OnStateEnter(T owner);

	/// <summary>
	/// This method is called every frame update after OnStateEnter and before OnStateExit
	/// </summary>
	/// <param name="owner">The owner of the state machine</param>
	public abstract void OnStateUpdate(T owner);

	/// <summary>
	/// This method is called when the state machine exits the state. Note, this method is called just before the next 
	/// state's OnStateEnter function and in the same update call
	/// </summary>
	/// <param name="owner">The owner of the state machine</param>
	public abstract void OnStateExit(T owner);
}
