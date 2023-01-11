using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneButton : AbstractButton
{
    [SerializeField] private string _sceneName;
    [SerializeField] private AudioClip _audioClip;
    protected override void Click()
    {
        SceneManager.LoadScene(_sceneName);
        AudioActions.PlaySound(_audioClip);
    }
}
