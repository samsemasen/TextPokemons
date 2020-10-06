using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squirtle : Pokemon
{
    public InputManager input;
    private squirtleAttacks _attackChoice;

    public enum squirtleAttacks
    {
        AquaTail,
        TailWhip,
        WaterGun,
        WaterPulse
    }

    public void Squirt()
    {
        _attackChoice = input.Choose(squirtleAttacks.AquaTail, squirtleAttacks.TailWhip, squirtleAttacks.WaterGun, squirtleAttacks.WaterPulse);
        Attack(_attackChoice);

    }
}
