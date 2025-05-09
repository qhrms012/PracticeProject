using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine 
{
    private Istate currentState;

    public void SetState(Istate newState)
    {
        if(currentState != null)
            currentState.Exit();

        currentState = newState;
        currentState.Enter();
    }

    public void Update(Vector3 playerVector)
    {
        if(currentState != null)
            currentState.Execute(playerVector);
    }
}
