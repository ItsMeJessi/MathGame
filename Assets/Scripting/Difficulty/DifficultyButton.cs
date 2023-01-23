using UnityEngine;

public class DifficultyButton : AbstractButton
{
    [SerializeField] private int _difficultyLevelIndex;

    protected override void Click()
    {
        GameActions.SetDifficultyLevel(_difficultyLevelIndex);
    }
}
