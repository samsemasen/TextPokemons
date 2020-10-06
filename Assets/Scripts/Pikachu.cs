using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pikachu : Pokemon
{
    public InputManager input;
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
        _attackChoice = input.Choose( PikatchuAttacks.Growl, PikatchuAttacks.ThunderShock, PikatchuAttacks.TailWhip, PikatchuAttacks.Slam);
        Attack(_attackChoice);
    }
}
