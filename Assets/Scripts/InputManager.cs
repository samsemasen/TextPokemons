using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class InputManager : Singleton<InputManager>
{
    public ChoiceEvent OnChoiceGiven = new ChoiceEvent();

    public GameObject buttonsPanel;

    public static int choice;
    public static bool clicked = false;

    public Text button1Text;
    public Text button2Text;
    public Text button3Text;
    public Text button4Text;

    private void OnEnable()
    {
        BattleSystem.Instance.OnBattleOver.AddListener(HideButtons);
    }
    private void OnDisable()
    {
        BattleSystem.Instance.OnBattleOver.RemoveListener(HideButtons);
    }


    public void UpdateButtonTexts(string _button1, string _button2, string _button3, string _button4)
    {
        //buttonsPanel.SetActive(true);
        button1Text.text = _button1;
        button2Text.text = _button2;
        button3Text.text = _button3;
        button4Text.text = _button4;

    }  

    public void ShowButtons(string _button1, string _button2, string _button3, string _button4)
    {
        UpdateButtonTexts(_button1, _button2, _button3, _button4);
        buttonsPanel.SetActive(true);


    }

    public void HideButtons(BattleState _battleState)
    {
        buttonsPanel.SetActive(false);
    }

    public void SetChoice(int num)
    {
        choice = num;
        Debug.Log(" button works fine-- you choose button" + choice);
        OnChoiceGiven.Invoke(choice);
        buttonsPanel.SetActive(false);

        clicked = true;
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

public class ChoiceEvent : UnityEvent<int> { }