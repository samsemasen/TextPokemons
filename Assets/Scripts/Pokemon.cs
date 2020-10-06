using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pokemon : MonoBehaviour
{
    public void Attack<T>(T attackChoice)
    {
        Debug.Log("attack " + attackChoice);
    }

}
