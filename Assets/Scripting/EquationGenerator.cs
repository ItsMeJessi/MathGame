using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class EquationGenerator : MonoBehaviour
{
    [SerializeField] private UIManager _uiManager;
    
    private int _givenNumber;
    private int _missingNumber;
    private int _resultNumber;

    public delegate void EquationGenerated(int missingNumberValue);
    public event EquationGenerated EquationGeneratedEvent;

    private void Start()
    {
        GenerateEquation();
    }

    private void GenerateEquation()
    {
        _givenNumber = GetRandomValue();
        _resultNumber = GetResultNumber();

        _missingNumber = _resultNumber - _givenNumber;
        
        EquationGeneratedEvent?.Invoke(_missingNumber);
        ShowNumbersOnUI();
    }

    private int GetRandomValue()
    {
        return Random.Range(0, 10);
    }

    private int GetResultNumber()
    {
        return Random.Range(_givenNumber, 10);
    }

    private void ShowNumbersOnUI()
    {
        _uiManager.SetGivenNumberText(_givenNumber);
        _uiManager.SetResultNumberText(_resultNumber);
    }
}
