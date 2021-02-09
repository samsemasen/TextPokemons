using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulbasaur : Pokemon
{

    public Bulbasaur(int _damage, int _maxHP)
    {
        PokemonType = PokemonType.Bulbasaur;
        PokemonAttacks = new Attack[] { new Growl(), new Slam(), new Tackle(), new PoisonPowder() };
        //PokemonAttacks = new string[] { "PoisonPowder,SleepPowder,Tackle,VineWhip" };
        damage = _damage;
        maxHP = _maxHP;
        currentHP = _maxHP;
    }

}
