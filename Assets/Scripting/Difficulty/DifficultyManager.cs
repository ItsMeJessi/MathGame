using System;
using UnityEngine;

public class DifficultyManager : MonoBehaviour
{
    [SerializeField] private CurrentGameConfig _currentGameConfig;

    private void OnEnable()
    {
        GameActions.SetDifficultyLevel += UstawPoziomTrudnosci;
    }

    private void OnDisable()
    {
        GameActions.SetDifficultyLevel -= UstawPoziomTrudnosci;
    }

    private void UstawPoziomTrudnosci(DifficultyLevel difficultyLevel)
    {
        _currentGameConfig.CurrentDifficultyLevel = difficultyLevel;
    }
}
