using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DropDownScript : MonoBehaviour
{
    [SerializeField] private ActionBasedSnapTurnProvider snapTurn;
    [SerializeField] private ActionBasedContinuousTurnProvider continuousTurn;

    public void TurnProviderSelect(int index)
    {
        if (index == 0)
        {
            snapTurn.enabled = true;
            continuousTurn.enabled = false;
        }
        if (index == 1)
        {
            snapTurn.enabled = false;
            continuousTurn.enabled = true;
        }
    }

    public void Exit()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}
