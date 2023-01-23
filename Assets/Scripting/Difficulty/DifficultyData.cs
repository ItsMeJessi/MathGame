using UnityEngine;

[CreateAssetMenu(menuName = "Data/Difficulty")]
public class DifficultyData : ScriptableObject
{
    [SerializeField] private DifficultyLevel[] _additionLevels;
    [SerializeField] private DifficultyLevel[] _substractionLevels;
    [SerializeField] private DifficultyLevel[] _multiplicationLevels;
    [SerializeField] private DifficultyLevel[] _divisionLevels;

    public DifficultyLevel[] AdditionLevels => _additionLevels;
    public DifficultyLevel[] SubtractionLevels => _substractionLevels;
    public DifficultyLevel[] MultiplicationLevels => _multiplicationLevels;
}
