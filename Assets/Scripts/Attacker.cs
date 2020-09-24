using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
	private readonly charmenderAttacks _attackType;

	public Attacker(charmenderAttacks attackType)
	{
		_attackType = attackType;
	}

	public void Attack()
	{
		Debug.Log("attack " + _attackType);
	}
}

enum charmenderAttacks
{
	FireBlast,
	Slash,
	WingAttack,
	FireStorm
}