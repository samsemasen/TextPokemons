using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulbasaur : Pokemon
{
    public InputManager input;
    private bulbasaurAttacks _attackChoice;

    public enum bulbasaurAttacks
    {
        PoisonPowder,
        SleepPowder,
        Tackle,
        VineWhip
    }

    public void Bulba()
    {
        _attackChoice = input.Choose(bulbasaurAttacks.PoisonPowder, bulbasaurAttacks.SleepPowder, bulbasaurAttacks.Tackle, bulbasaurAttacks.VineWhip);
        Attack(_attackChoice);

    }
}
