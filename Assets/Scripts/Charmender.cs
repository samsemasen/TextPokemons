using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charmender : Pokemon
{

    private Attacker _attacker;

    public void Init()
    {
        _attacker = new Attacker(charmenderAttacks.Slash);

        Start();
    } 



    

}
