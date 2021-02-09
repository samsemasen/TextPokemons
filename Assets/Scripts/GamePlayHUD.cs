using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;


public class GamePlayHUD : Singleton<GamePlayHUD>
{

	//public Text narrativeText;
	public TMP_Text narrativeText;


	public NarrativeTextEvent OnNarrativeTextUpdated = new NarrativeTextEvent();


	private void OnEnable()
	{
		OnNarrativeTextUpdated.AddListener(UpdateNarrativeText);
	}

	private void OnDisable()
	{
		OnNarrativeTextUpdated.RemoveListener(UpdateNarrativeText);
	}


	public void UpdateNarrativeText(string _updatedText)
	{
		narrativeText.text += "\n"+ _updatedText;
	}
}

public class NarrativeTextEvent : UnityEvent<string> { }