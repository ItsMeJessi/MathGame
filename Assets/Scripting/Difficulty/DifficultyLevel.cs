using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Difficulty", fileName = "DifficultyLevel", order = 1)]
public class DifficultyLevel : ScriptableObject
{
    [SerializeField] private string _difficultyName;
    [SerializeField] private int _minValue;
    [SerializeField] private int _maxValue;

    [SerializeField] private int _rounds;

    public int MinValue => _minValue;
    public int MaxValue => _maxValue;
}
