using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charmander : Pokemon
{
    private charmanderAttacks _attackChoice;
    
    public InputManager input;

    public enum charmanderAttacks
    {
        FireBlast,
        Slash,
        WingAttack,
        FireStorm
    }

    public void Charmie()
    {
        Debug.Log("choose charmander attack");
        int choice = input.GetChoice();
        _attackChoice = AttackChoose(choice, charmanderAttacks.FireBlast, charmanderAttacks.FireStorm, charmanderAttacks.Slash, charmanderAttacks.WingAttack);
        Attack(_attackChoice);

    }
    
}
