using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AnswersManager : MonoBehaviour
{
    [SerializeField] private List<AnswerButton> _answerButtons;

    private List<int> _registeredNumbers;

    private void Start()
    {
        _registeredNumbers = new List<int>();
        SetAnswerButtons();
    }

    private void SetAnswerButtons()
    {
        foreach (var answerButton in _answerButtons)
        {
            var value =  Random.Range(0, 10);
            answerButton.SetButtonLabel(value);
            RegisterNumber(value);
        }
    }

    private void RegisterNumber(int value)
    {
        _registeredNumbers.Add(value);
    }
}
