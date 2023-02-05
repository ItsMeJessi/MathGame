using UnityEngine;

[CreateAssetMenu(menuName = "Data/Difficulty")]
public class DifficultyData : ScriptableObject
{
    [field: SerializeField] public DifficultyLevel[] AdditionLevels { get; private set; }
    [field: SerializeField] public DifficultyLevel[] SubtractionLevels { get; private set; }
    [field: SerializeField] public DifficultyLevel[] MultiplicationLevels { get; private set; }
    [field: SerializeField] public DifficultyLevel[] DivisionLevels { get; private set; }
}
