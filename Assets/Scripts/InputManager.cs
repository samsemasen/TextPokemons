using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public Charmander charmi;
  

    public void GetInput(int num)
    {
        charmi.AttackChoose(num);
        charmi.Attack();
        Debug.Log("choose charmander attack");
    }
}
