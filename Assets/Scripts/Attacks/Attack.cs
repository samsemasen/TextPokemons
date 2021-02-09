using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Attack 
{
    public int damage;
}

public class AttackEvent : UnityEvent<Attack> { }

public class Tackle:Attack
{
    public Tackle()
    {
        damage = 25;
    }
}

public class Growl : Attack
{
    public Growl()
    {
        damage = 5;
    }
}

public class Slam : Attack
{
    public Slam()
    {
        damage = 30;
    }
}

public class ThunderShock : Attack
{
    public ThunderShock()
    {
        damage = 50;
    }
}

public class WaterGun : Attack
{
    public WaterGun()
    {
        damage = 50;
    }
}

public class FireStorm : Attack
{
    public FireStorm()
    {
        damage = 50;
    }
}

public class PoisonPowder : Attack
{
    public PoisonPowder()
    {
        damage = 50;
    }
}
