using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charmander 
{

    public Attacker _attacker;
    public InputManager choice;

    private charmanderAttacks attackChoice;


    public void Attack()
    {
        Debug.Log("attack " + attackChoice);
    }

    public enum charmanderAttacks
    {
        FireBlast,
        Slash,
        WingAttack,
        FireStorm
    }

    public void AttackChoose(int num)
    {
        switch (num) {
            case 1: attackChoice = charmanderAttacks.FireBlast; break;
            case 2: attackChoice = charmanderAttacks.FireStorm; break;
            case 3: attackChoice = charmanderAttacks.Slash; break;
            case 4: attackChoice = charmanderAttacks.WingAttack; break;
            default: throw new ArgumentException("Incorrect Charmander Attack");
        }

    }

    private void Start()
    {
        //AttackChoose(3);
       // Attack();
    }
}
