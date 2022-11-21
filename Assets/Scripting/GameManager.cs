using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private EquationGenerator _equationGenerator;
    
    public static GameManager Instance;

    public int CurrentRound = 1;
    
    private int _maxRounds = 10;
    private bool _isPlaying;

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

    private void Start()
    {
        SetUpGame();
        _isPlaying = true;
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
            _isPlaying = false;
            //todo: finish panel?
        }
    }

    public void LoadNextEquation()
    {
        GoToNextRound();
    }
}
