using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charmander : Pokemon
{
    public InputManager input;
    private charmanderAttacks _attackChoice;

    public enum charmanderAttacks
    {
        FireBlast,
        Slash,
        WingAttack,
        FireStorm
    }

    public void Charmie()
    {
        _attackChoice = input.Choose(charmanderAttacks.FireBlast, charmanderAttacks.FireStorm, charmanderAttacks.Slash, charmanderAttacks.WingAttack);
        Attack(_attackChoice);

    }   
}
