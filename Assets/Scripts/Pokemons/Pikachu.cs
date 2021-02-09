using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pikachu : Pokemon
{

    public Pikachu(int _damage, int _maxHP)
    {
        PokemonType = PokemonType.Pikachu;
        PokemonAttacks = new Attack[] { new Growl(), new Slam(), new Tackle(), new ThunderShock() };
            //new string[] { "Growl,ThunderShock,TailWhip,Slam" };
        damage = _damage;
        maxHP = _maxHP;
        currentHP = _maxHP;
    }

}
