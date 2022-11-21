using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class EquationGenerator : MonoBehaviour
{
    [SerializeField] private UIManager _uiManager;
    
    private int _givenNumber;
    private int _missingNumber;
    private int _resultNumber;

    private void Start()
    {
        GenerateEquation();
    }

    private void GenerateEquation()
    {
        _givenNumber = GetRandomValue();
        _resultNumber = GetRandomValue();

        _missingNumber = _resultNumber - _givenNumber;
        
        ShowNumbersOnUI();
    }

    private int GetRandomValue()
    {
        return Random.Range(0, 10);
    }

    private void ShowNumbersOnUI()
    {
        _uiManager.SetGivenNumberText(_givenNumber);
        _uiManager.SetResultNumberText(_resultNumber);
    }
}
