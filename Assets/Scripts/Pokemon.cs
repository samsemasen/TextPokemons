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

    public T AttackChoose<T>(int num , T attack1, T attack2, T attack3, T attack4)
    {

        switch(num) {
            case 1: return attack1; break;
            case 2: return attack2; break;
            case 3: return attack3; break;
            case 4: return attack4; break;
            default: throw new ArgumentException("Incorrect Attack");
        }
        
    }

}
