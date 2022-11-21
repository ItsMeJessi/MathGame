using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AnswersManager : MonoBehaviour
{
    [SerializeField] private List<AnswerButton> _answerButtons;
    [SerializeField] private EquationGenerator _equationGenerator;

    private List<int> _registeredNumbers;
    private readonly int[] _answers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    private List<int> _availableAnswers;

    private void OnEnable()
    {
        _equationGenerator.EquationGeneratedEvent += SetCorrectAnswerButton;
    }

    private void OnDisable()
    {
        _equationGenerator.EquationGeneratedEvent -= SetCorrectAnswerButton;
    }

    private void Start()
    {
        _registeredNumbers = new List<int>();
        SetAnswerButtons();
    }

    private void SetCorrectAnswerButton(int value)
    {
        _availableAnswers = new List<int>(_answers);
        var index = Random.Range(0, _answerButtons.Count);
        _answerButtons[index].SetButtonLabel(value);
        _answerButtons[index].isCorrectAnswer = true;
        _availableAnswers.Remove(value);
    }

    [ContextMenu("SetNewAnswers")]
    private void SetAnswerButtons()
    {
        foreach (var answerButton in _answerButtons)
        {
            if(answerButton.isTaken) continue;
            
            var index = Random.Range(0, _availableAnswers.Count);
            var value = _availableAnswers[index];
            _availableAnswers.RemoveAt(index);
            
            answerButton.SetButtonLabel(value);
            _registeredNumbers.Add(value);
        }
    }
}