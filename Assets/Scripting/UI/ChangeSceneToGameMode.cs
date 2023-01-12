using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneToGameMode : AbstractButton
{
    [SerializeField] private CurrentGameConfig _currentGameConfig;
    [SerializeField] private AudioClip _audioClip;
    protected override void Click()
    {
        AudioActions.PlaySound(_audioClip);
        SceneManager.LoadScene(_currentGameConfig.GameMode);
    }
}
