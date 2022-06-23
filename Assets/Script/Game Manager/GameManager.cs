using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameState State;

    void Awake()
    {
        Instance = this;
    }

    public void UpdateGameStete(GameState newState)
    {
        State = newState;

        switch (newState)
        {
            case GameState.Player:
                break;
            case GameState.Win:
                break;
            case GameState.Lose:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }
    }
}

public enum GameState
{
    Player,
    Win,
    Lose
}
