using UnityEngine;
using Random = UnityEngine.Random;

public abstract class EquationGenerator : MonoBehaviour
{
    [SerializeField] private UIManager _uiManager;
    [SerializeField] protected int _minValue = 1;
    [SerializeField] protected int _maxValue = 10;

    protected int _givenNumber;
    protected int _missingNumber;
    protected int _resultNumber;

    public delegate void EquationGenerated(int missingNumberValue);
    public event EquationGenerated EquationGeneratedEvent;

    private void OnEnable()
    {
        BindEvents();
    }

    private void OnDisable()
    {
        UnbindEvents();
    }

    private void BindEvents()
    {
        GameActions.CorrectAnswer += ShowMissingNumberOnUI;
    }

    private void UnbindEvents()
    {
        GameActions.CorrectAnswer -= ShowMissingNumberOnUI;
    }

    public void GenerateEquation()
    {
        GameActions.GeneratorReset?.Invoke();
        SetNumbers();

        EquationGeneratedEvent?.Invoke(_missingNumber);
        ShowNumbersOnUI();
    }

    protected virtual void SetNumbers()
    {
        _givenNumber = GetRandomValue();
        _resultNumber = GetResultNumber();
    }

    private int GetRandomValue()
    {
        return Random.Range(_minValue, _maxValue);
    }

    protected virtual int GetResultNumber()
    {
        return Random.Range(_givenNumber + 1, _maxValue);
    }

    private void ShowNumbersOnUI()
    {
        _uiManager.ResetMissingNumberToQuestionMark();
        _uiManager.SetGivenNumberText(_givenNumber);
        _uiManager.SetResultNumberText(_resultNumber);
    }

    private void ShowMissingNumberOnUI()
    {
        _uiManager.SetMissingNumberText(_missingNumber);
    }
}