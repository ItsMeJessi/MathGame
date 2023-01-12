using UnityEngine;

[CreateAssetMenu(menuName = "Configs/CurrentGameConfig", fileName = "CurrentGameConfig", order = 3)]
public class CurrentGameConfig : ScriptableObject
{
    public DifficultyLevel CurrentDifficultyLevel;
}
