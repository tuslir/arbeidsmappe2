/// <summary>
/// Interface for a generic finite state machine
/// </summary>
/// <typeparam name="T">The owner of the state machine, or it's context</typeparam>
public interface IFiniteStateMachine<T>
{
    public void Start(StateMachineState<T> state);
    public void Update();
}
