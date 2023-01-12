using UnityEngine;

public class SetGameModeButton : AbstractButton
{
    [SerializeField] private CurrentGameConfig _currentGameConfig;
    [SerializeField] private string _gameMode;

    protected override void Click()
    {
        _currentGameConfig.GameMode = _gameMode;
    }
}
