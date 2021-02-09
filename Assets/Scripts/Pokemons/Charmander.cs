using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charmander : Pokemon
{
    public Charmander(int _damage, int _maxHP)
    {
        PokemonType = PokemonType.Charmander;
        PokemonAttacks = new Attack[] { new Growl(), new Slam(), new Tackle(), new FireStorm() };
        //PokemonAttacks = new string[] { "FireBlast,Slash,WingAttack,FireStorm" };
        damage = _damage;
        maxHP = _maxHP;
        currentHP = _maxHP;
    }

}
