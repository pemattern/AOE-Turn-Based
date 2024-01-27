using System.Linq;
using UnityEngine;

public abstract class FiniteStateMachine : MonoBehaviour
{
    private State _currentState;
    protected State[] _states;

    public void Initialize(State[] states)
    {
        _states = states;
        if (states.Length > 0)
        {
            SetState(states[0]);
        }
    }

    protected void SetState(State state)
    {
        if (_states.Contains(state))
        {
            _currentState.Exit();
            _currentState = state;
            _currentState.Enter();
        }
    }

    private void Update()
    {
        _currentState?.Update();
    }
}