using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameState GameState;

    //Game manager Instance
    void Awake()
    {
        Instance = this;
    }

    //Start first GameState
    void Start()
    {
        ChangeState(GameState.GenerateGrid);
    }

    //Game state logic and switch function
    public void ChangeState(GameState newState)
    {
        GameState = newState;
        switch (newState)
        {
            case GameState.GenerateGrid:
            //GridManager.Instance.GenerateGrid();
                break;

                case GameState.HumanTurn:
                break;

                case GameState.HumanSpawn:
                break;

                case GameState.HumanAttack:
                break;                

                case GameState.OrcTurn:
                break;

                case GameState.OrcSpawn:
                break;

                case GameState.OrcAttack:
                break;                    

                //etc..

            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }
    }
}

//'Flow' of game
public enum GameState
{
    GenerateGrid,
    HumanTurn,
    HumanSpawn,
    HumanAttack,
    OrcTurn,
    OrcSpawn,
    OrcAttack
}
