using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : Singleton<GameManager>
{
    private void OnEnable()
    {
        BattleSystem.Instance.OnBattleOver.AddListener(GameOver);
    }
    private void OnDisable()
    {
        BattleSystem.Instance.OnBattleOver.RemoveListener(GameOver);
    }

    public void GameOver(BattleState _battleState)
    {
        if(_battleState == BattleState.WON)
        {
            GamePlayHUD.Instance.OnNarrativeTextUpdated.Invoke("YOU WON");
            //ENDGAME
        }
        else if(_battleState == BattleState.LOST)
        {
            GamePlayHUD.Instance.OnNarrativeTextUpdated.Invoke("YOU LOST");
            //ENDGAME
        }


    }

    //based on states end game
    // keep asking for attack? 
    //in here?
}

