using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateCheck : MonoBehaviour
{
    [SerializeField] private GameState currentState;
    [SerializeField] private GameObject HeartNote;

    private void Awake()
    {
        if (currentState.boneBoss && currentState.ratBoss)
        {
            HeartNote.SetActive(true);
        }
    }

}
