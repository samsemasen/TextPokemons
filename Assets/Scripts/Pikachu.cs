using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pikachu : Pokemon
{
    private PikatchuAttacks _attackChoice;

    public enum PikatchuAttacks
    {
        Growl,
        ThunderShock,
        TailWhip,
        Slam
    }

    public void Pika()
    {
        _attackChoice = AttackChoose(InputManager.choice, PikatchuAttacks.Growl,PikatchuAttacks.ThunderShock,PikatchuAttacks.TailWhip, PikatchuAttacks.Slam);
        Attack(_attackChoice);
    }
}
