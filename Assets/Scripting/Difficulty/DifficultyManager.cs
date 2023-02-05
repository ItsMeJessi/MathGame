using UnityEngine;

public class DifficultyManager : MonoBehaviour
{
    [SerializeField] private CurrentGameConfig _currentGameConfig;
    [SerializeField] private DifficultyData _difficultyData;

    private void OnEnable()
    {
        GameActions.SetDifficultyLevel += SetDifficultyLevel;
    }

    private void OnDisable()
    {
        GameActions.SetDifficultyLevel -= SetDifficultyLevel;
    }

    private void SetDifficultyLevel(int difficultyLevelIndex)
    {
        _currentGameConfig.CurrentDifficultyLevel = GetDifficultyLevelFromData(difficultyLevelIndex);
    }

    private DifficultyLevel GetDifficultyLevelFromData(int difficultyLeveLIndex)
    {
        var difficultyLevel = _currentGameConfig.GameMode switch
        {
            "Addition" => _difficultyData.AdditionLevels[difficultyLeveLIndex],
            "Subtraction" => _difficultyData.SubtractionLevels[difficultyLeveLIndex],
            "Multiplication" => _difficultyData.MultiplicationLevels[difficultyLeveLIndex],
            "Division" => _difficultyData.DivisionLevels[difficultyLeveLIndex],
            _ => _difficultyData.AdditionLevels[difficultyLeveLIndex]
        };

        return difficultyLevel;
    }
}
