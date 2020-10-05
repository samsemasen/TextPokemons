using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Charmander charmi;
    public Pikachu pika;
    public InputManager input;
    private PokemonTypes chosen;

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
        if (InputManager.clicked) {
            chosen = input.Choose(PokemonTypes.Pikachu, PokemonTypes.Charmender, PokemonTypes.Bulbasaur, PokemonTypes.Squirtle);
            Debug.Log("you choose" + chosen);
            Debug.Log("choose attack");
        }
       
    }

    private void Update()
    {
        if (InputManager.clicked) {
            if (chosen == PokemonTypes.Pikachu) {
                pika.Pika();
            }else if (chosen == PokemonTypes.Charmender) {
                charmi.Charmie();
            }

            Debug.Log("choose attack");
            InputManager.clicked = false;
        }

    }
}