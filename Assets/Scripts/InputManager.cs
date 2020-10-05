using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    public static int choice ;
    public static bool clicked = false;

    public void SetChoice(int num)
    {
        choice = num;
        clicked = true;
    }

    public int GetChoice()
    {
        return choice;
    }

    public T Choose<T>(T option1, T option2, T option3, T option4)
    {

        switch (choice) {
            case 1: return option1; break;
            case 2: return option2; break;
            case 3: return option3; break;
            case 4: return option4; break;
            default: throw new ArgumentException("Incorrect Attack");
        }

    }

}
