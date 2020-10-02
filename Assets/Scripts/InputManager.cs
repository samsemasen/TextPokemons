using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public Charmander charmi;

    public int choice;
  
    public void SetChoice(int num)
    {
        choice = num;
    }

    public int GetChoice()
    {
        return choice;
    }

}
