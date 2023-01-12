using System;
using UnityEngine;

public class DifficultyManager : MonoBehaviour
{
    [SerializeField] private DifficultyLevel _easy;
    [SerializeField] private DifficultyLevel _medium;
    [SerializeField] private DifficultyLevel _hard;
    
    [SerializeField] private CurrentGameConfig _currentGameConfig;

    private void Awake()
    {
        _currentGameConfig.CurrentDifficultyLevel = _medium;
    }
}
