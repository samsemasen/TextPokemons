using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Squirtle : Pokemon
{

    public Squirtle(int _damage, int _maxHP)
    {
        PokemonType = PokemonType.Squirtle;
        PokemonAttacks = new Attack[] { new Growl(), new Slam(), new Tackle(), new WaterGun() };
        //PokemonAttacks = new string[] { "AquaTail,TailWhip,WaterGun,WaterPulse" };
        damage = _damage;
        maxHP = _maxHP;
        currentHP = _maxHP;
    }

}
