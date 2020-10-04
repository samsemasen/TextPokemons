using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Charmander charmi;
    public Pikachu pika;
    public InputManager input;

    private void Start()
    {
        Debug.Log("choose pokemon");
        //Pokemon chosen = input.Choose(pika, pika, charmi, charmi);


        Debug.Log("choose attack");
    }

    private void Update()
    {
        if (InputManager.clicked) {           
            //charmi.Charmie();
            pika.Pika();
            Debug.Log("choose attack");
            InputManager.clicked = false;
        }

    }
}


//walk 
// have chance to see a pokemon
// have fight
// win or die