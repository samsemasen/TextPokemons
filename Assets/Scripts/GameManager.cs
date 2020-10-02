using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Charmander charmi;
    public InputManager input;
    private void Start()
    {
        

        if(input.GetChoice() != null)
            {
            Debug.Log("choose pokemons");
            charmi.Charmie();
        }
    }


}
