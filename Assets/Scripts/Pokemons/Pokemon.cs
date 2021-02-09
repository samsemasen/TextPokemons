using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum PokemonType { NonValid, Pikachu, Charmander, Bulbasaur, Squirtle }


public abstract class Pokemon 
{
    public PokemonType PokemonType;
    public Attack[] PokemonAttacks;
    public int damage;
    public int maxHP;
    public int currentHP;

    public void GetDamage(int _damage)
    {
        currentHP -= _damage;
        GamePlayHUD.Instance.OnNarrativeTextUpdated.Invoke(PokemonType.ToString() + " now has " + currentHP + " currentHP");
        if (currentHP <= 0)
            Die();
    }

    public void Die()
    {
        GamePlayHUD.Instance.OnNarrativeTextUpdated.Invoke(PokemonType.ToString() + " DIED ");
        BattleSystem.Instance.OnPokemonDied.Invoke(this);
    }

}

public class PokemonEvent : UnityEvent<Pokemon> { }