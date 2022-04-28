using UnityEngine;

public class StateMachineOwner : MonoBehaviour
{
	[SerializeField] private KeyCode toggleHappy;
	[SerializeField] private KeyCode toggleAngry;
	[SerializeField] private KeyCode toggleDead;

	// State parameters
	private bool isAngry;
	private bool isHappy;
	private bool isDead;

	private FiniteStateMachine<StateMachineOwner> machine;
	protected NormalState normalState = new NormalState();
	protected HappyState happyState = new HappyState();
	protected AngryState angryState = new AngryState();
	protected DeadState deadState = new DeadState();

	private void Awake()
	{
		machine = new FiniteStateMachine<StateMachineOwner>(this);
		machine.AddTransition(normalState, happyState, (IsHappy, true));
		machine.AddTransition(happyState, normalState, (IsHappy, false));
		machine.AddTransition(normalState, angryState, (IsAngry, true));
		machine.AddTransition(angryState, normalState, (IsAngry, false));
		machine.AddGlobalTransition(deadState, (IsDead, true));
	}

	private void Start()
	{
		machine.Start(normalState);
	}

	private void Update()
	{
		if(Input.GetKeyDown(toggleAngry))
		{
			isAngry = !isAngry;
		}

		if (Input.GetKeyDown(toggleHappy))
		{
			isHappy = !isHappy;
		}

		if (Input.GetKeyDown(toggleDead))
		{
			isDead = !isDead;
		}

		machine.Update();
	}

	private bool IsHappy()
	{
		return isHappy;
	}

	private bool IsAngry()
	{
		return isAngry;
	}

	private bool IsDead()
	{
		return isDead;
	}
}
