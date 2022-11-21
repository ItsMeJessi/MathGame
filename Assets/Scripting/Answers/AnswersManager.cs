using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class AnswersManager : MonoBehaviour
{
    [SerializeField] private List<AnswerButton> _answerButtons;
    [SerializeField] private EquationGenerator _equationGenerator;
    
    private readonly int[] _answers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    private List<int> _availableAnswers;

    private void OnEnable()
    {
        _equationGenerator.EquationGeneratedEvent += SetAnswers;
        GameActions.LockButtons += LockButtons;
        GameActions.UnlockButtons += UnlockButtons;
    }

    private void OnDisable()
    {
        _equationGenerator.EquationGeneratedEvent -= SetAnswers;
        GameActions.LockButtons -= LockButtons;
        GameActions.UnlockButtons -= UnlockButtons;
        
    }
    
    private void SetAnswers(int value)
    {
        _availableAnswers = new List<int>(_answers);
        
        ResetButtons();
        SetCorrectAnswerButton(value);
    }

    private void ResetButtons()
    {
        foreach (var button in _answerButtons)
        {
            button.isCorrectAnswer = false;
            button.isTaken = false;
        }
    }

    private void SetCorrectAnswerButton(int value)
    {
        SetButtonInfo(value);
        RemoveFromAvailableAnswers(value);
        SetAnswerButtons();
    }

    private void SetButtonInfo(int value)
    {
        var index = Random.Range(0, _answerButtons.Count);
        _answerButtons[index].SetButtonLabel(value);
        _answerButtons[index].isCorrectAnswer = true;
    }

    private void RemoveFromAvailableAnswers(int value)
    {
        _availableAnswers.Remove(value);
    }

    [ContextMenu("SetNewAnswers")]
    private void SetAnswerButtons()
    {
        foreach (var answerButton in _answerButtons.Where(answerButton => !answerButton.isTaken))
        {
            SetRandomAnswer(answerButton);
        }
    }

    private void SetRandomAnswer(AnswerButton button)
    {
        var index = Random.Range(1, _availableAnswers.Count);
        var value = _availableAnswers[index];
        _availableAnswers.RemoveAt(index);
            
        button.SetButtonLabel(value);
    }

    private void LockButtons()
    {
        foreach (var button in _answerButtons)
        {
            button.GetComponent<Button>().interactable = false;
        }
    }
    
    private void UnlockButtons()
    {
        foreach (var button in _answerButtons)
        {
            button.GetComponent<Button>().interactable = true;
        }
    }
}