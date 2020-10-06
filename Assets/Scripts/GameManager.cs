using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Charmander charmi;
    public Pikachu pika;
    public Bulbasaur bulba;
    public Squirtle squirt;
    public InputManager input;
    private PokemonTypes chosen;
    private bool pokemonChosen = false;

    public enum PokemonTypes
    {
        Pikachu ,
        Charmender,
        Bulbasaur,
        Squirtle

    }

    private void Start()
    {
        Debug.Log("choose pokemon");     
    }

    private void Update()
    {
        if (InputManager.clicked && !pokemonChosen) {
            chosen = input.Choose(PokemonTypes.Pikachu, PokemonTypes.Charmender, PokemonTypes.Bulbasaur, PokemonTypes.Squirtle);
            Debug.Log("you choose" + chosen);
            pokemonChosen = true;
            InputManager.clicked = false;
            Debug.Log("choose attack");
        } else if (InputManager.clicked) {
            switch (chosen) {
                case PokemonTypes.Bulbasaur: bulba.Bulba();break;
                case PokemonTypes.Charmender: charmi.Charmie();break;
                case PokemonTypes.Pikachu: pika.Pika();break;
                case PokemonTypes.Squirtle: squirt.Squirt();break;
                default: throw new ArgumentException("Incorrect Attack");
            }
            Debug.Log("choose attack");
            InputManager.clicked = false;
        }

    }
}