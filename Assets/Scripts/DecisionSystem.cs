using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionSystem : Singleton<DecisionSystem>
{

    Pokemon playerPokemon;

    private void OnEnable()
    {
        InputManager.Instance.OnChoiceGiven.AddListener(GiveDesition);
    }

    private void OnDisable()
    {
        InputManager.Instance.OnChoiceGiven.RemoveListener(GiveDesition);
    }

    public  void GiveDesition(int _choice)
    {
        if (BattleSystem.Instance.state == BattleState.START)
        {
            playerPokemon = ChooseStarterPokemon(_choice);
            BattleSystem.Instance.OnStaterPokemonChoosed.Invoke(playerPokemon);
        } 
        else
        {
            Attack playerAttack = ChooseAttack(_choice , playerPokemon);
            BattleSystem.Instance.OnPlayerAttackChoosen.Invoke(playerAttack);
        }
            
    }

    public  Pokemon ChooseRandomStarterPokemon()
    {
        int randNum = Random.Range(1, 5);
        return ChooseStarterPokemon(randNum);
 
    }


    // for player from input , for enemy random
    public Pokemon ChooseStarterPokemon(int _choice)
    {
        PokemonType chosenPokemonType = Choose(/*PokemonType.NonValid,*/ PokemonType.Pikachu, PokemonType.Charmander, PokemonType.Bulbasaur, PokemonType.Squirtle, _choice);

        switch (chosenPokemonType)
        {
            case PokemonType.Bulbasaur:
                Bulbasaur newBulbasaur = new Bulbasaur(20, 100);
                return newBulbasaur;
            case PokemonType.Charmander:
                Charmander newCharmender = new Charmander(20, 100);
                return newCharmender;
            case PokemonType.Pikachu:
                Pikachu newPikachu = new Pikachu(20, 100);
                return newPikachu;
            case PokemonType.Squirtle:
            default:
                Squirtle newSquirtle = new Squirtle(20, 100);
                return newSquirtle;           
        }

    }

    public Attack ChooseRandomAttack(Pokemon _pokemon)
    {
        int randNum = Random.Range(1, 5);
        return ChooseAttack(randNum, _pokemon);
    }

    // for player from input , for enemy random
    public Attack ChooseAttack(int _choice , Pokemon _pokemon)
    {
        return Choose(_pokemon.PokemonAttacks[0], _pokemon.PokemonAttacks[1], _pokemon.PokemonAttacks[2], _pokemon.PokemonAttacks[3], _choice);
    }


    public T Choose<T>(/*T option0,*/ T option1, T option2, T option3, T option4, int _choice)
    {

        switch (_choice)
        {
            case 1:
                return option1;
            case 2:
                return option2;
            case 3:
                return option3;
            case 4:
            default:
                return option4;
            //default:
            //    return option0;
        }

    }

}

