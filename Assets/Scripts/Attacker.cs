using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
	private readonly charmanderAttacks _attackType;

	public Attacker(charmanderAttacks attackType)
	{
		_attackType = attackType;
	}

	public void Attack()
	{
		Debug.Log("in attack");
		Debug.Log("attack " + _attackType);
	}
}
public enum charmanderAttacks
{
	FireBlast,
	Slash,
	WingAttack,
	FireStorm
}