using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum BattleState { START, INBATTLE , WON, LOST }

public class BattleSystem : Singleton<BattleSystem>
{

	public PokemonEvent OnStaterPokemonChoosed = new PokemonEvent();
	public PokemonEvent OnPokemonDied = new PokemonEvent();
	public AttackEvent OnPlayerAttackChoosen = new AttackEvent();
	public BattleStateEvent OnBattleOver = new BattleStateEvent();


	public BattleState state;

	private Pokemon playerPokemon;
	private Pokemon enemyPokemon;

	private void OnEnable()
	{
		OnStaterPokemonChoosed.AddListener(SetStarterPokemon);
		OnPlayerAttackChoosen.AddListener(PlayerAttack);
		OnPokemonDied.AddListener(EndBattle);
	}

	private void OnDisable()
	{
		OnStaterPokemonChoosed.RemoveListener(SetStarterPokemon);
		OnPlayerAttackChoosen.RemoveListener(PlayerAttack);
		OnPokemonDied.RemoveListener(EndBattle);
	}

	void Start()
	{
		state = BattleState.START;
		GamePlayHUD.Instance.OnNarrativeTextUpdated.Invoke("Please Choose an Pokemon");

		//InputManager.Instance.UpdateButtonTexts(PokemonTypes.Pikachu.ToString(), PokemonTypes.Charmender.ToString(), PokemonTypes.Bulbasaur.ToString(), PokemonTypes.Squirtle.ToString());
		InputManager.Instance.ShowButtons("Pikachu", "Charmender", "Bulbasaur", "Squirtle");
	}

	public void SetStarterPokemon(Pokemon _chosenPokemon)
	{
		playerPokemon = _chosenPokemon;
		GamePlayHUD.Instance.OnNarrativeTextUpdated.Invoke("You Choosed " + playerPokemon.PokemonType.ToString());
		StartCoroutine(SetupBattle());
	}
	IEnumerator SetupBattle()
	{
		enemyPokemon = DecisionSystem.Instance.ChooseRandomStarterPokemon();
		GamePlayHUD.Instance.OnNarrativeTextUpdated.Invoke("Enemy Choosed " + enemyPokemon.PokemonType.ToString());

		yield return new WaitForSeconds(2f);

		state = BattleState.INBATTLE;
		PlayerTurn();
	}

	void PlayerTurn()
	{
		if (state != BattleState.INBATTLE)
			return; 

		GamePlayHUD.Instance.OnNarrativeTextUpdated.Invoke("Please Choose an Attack");
		InputManager.Instance.ShowButtons(playerPokemon.PokemonAttacks[0].ToString(), playerPokemon.PokemonAttacks[1].ToString(), playerPokemon.PokemonAttacks[2].ToString(), playerPokemon.PokemonAttacks[3].ToString());
	}

	void PlayerAttack(Attack _chosenAttack)
	{

		GamePlayHUD.Instance.OnNarrativeTextUpdated.Invoke("You Choosed " + _chosenAttack.ToString());
		GamePlayHUD.Instance.OnNarrativeTextUpdated.Invoke("You made " + _chosenAttack.damage+ " damage to " + enemyPokemon.PokemonType.ToString());
		enemyPokemon.GetDamage(_chosenAttack.damage);
		StartCoroutine(EnemyTurn());
	}

	IEnumerator EnemyTurn()
	{
		yield return new WaitForSeconds(2f);
		EnemyAttack();
	}
	void EnemyAttack()
	{
		if (state != BattleState.INBATTLE)
			return;

		Attack enemyAttack = DecisionSystem.Instance.ChooseRandomAttack(enemyPokemon);
		GamePlayHUD.Instance.OnNarrativeTextUpdated.Invoke("Enemy Choosed " + enemyAttack.ToString());
		GamePlayHUD.Instance.OnNarrativeTextUpdated.Invoke(enemyPokemon.PokemonType.ToString() + " made "+ enemyAttack.damage + " damage to " + playerPokemon.PokemonType.ToString());
		playerPokemon.GetDamage(enemyAttack.damage);
		PlayerTurn();

	}

	public void EndBattle(Pokemon _deadPokemon)
	{
		if (_deadPokemon == enemyPokemon)
			state = BattleState.WON;
		else if(_deadPokemon == playerPokemon)
			state = BattleState.LOST;

		OnBattleOver.Invoke(state);

	}
}

public class BattleStateEvent : UnityEvent<BattleState> { }