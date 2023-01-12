using UnityEngine;

public class DifficultyButton : AbstractButton
{
    [SerializeField] private DifficultyLevel _difficultyLevel;

    protected override void Click()
    {
        GameActions.SetDifficultyLevel(_difficultyLevel);
    }
}
