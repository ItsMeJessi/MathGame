using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private EquationGenerator _equationGenerator;
    [SerializeField] private GameObject _gameplayUI;
    [SerializeField] private GameObject _finishPanelUI;
    
    public static GameManager Instance;

    public bool IsPlaying { get; private set; }
    public int CurrentRound = 1;

    private int _goodAnswers;
    private int _wrongAnswers;
    
    private int _maxRounds = 10;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    private void OnEnable()
    {
        BindEvents();
    }

    private void OnDisable()
    {
        UnbindEvents();
    }

    private void Start()
    {
        SetUpGame();
        IsPlaying = true;
    }

    private void BindEvents()
    {
        GameActions.AddGoodAnswerToCounter += IncreaseGoodAnswerCounter;
        GameActions.AddWrongAnswerToCounter += IncreaseWrongAnswerCounter;
    }

    private void UnbindEvents()
    {
        GameActions.AddGoodAnswerToCounter -= IncreaseGoodAnswerCounter;
        GameActions.AddWrongAnswerToCounter -= IncreaseWrongAnswerCounter;
    }

    private void SetUpGame()
    {
        CurrentRound = 1;
        GameActions.UpdateRoundCounter(CurrentRound);
        
        _equationGenerator.GenerateEquation();
    }

    private void GoToNextRound()
    {
        if (CurrentRound < _maxRounds)
        {
            CurrentRound++;
            GameActions.UpdateRoundCounter(CurrentRound);
            
            _equationGenerator.GenerateEquation();
        }
        else
        {
            Debug.Log("Finished.");
            IsPlaying = false;
            _gameplayUI.SetActive(false);
            
            _finishPanelUI.GetComponent<FinishPanel>().SetFinishPanelDetails(_goodAnswers, _wrongAnswers);
            _finishPanelUI.SetActive(true);
        }
    }

    private void IncreaseGoodAnswerCounter()
    {
        _goodAnswers++;
    }

    private void IncreaseWrongAnswerCounter()
    {
        _wrongAnswers++;
    }

    public void LoadNextEquation()
    {
        GoToNextRound();
    }
}
