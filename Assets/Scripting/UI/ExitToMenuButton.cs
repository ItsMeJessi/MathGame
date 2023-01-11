using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitToMenuButton : AbstractButton
{
    [SerializeField] private Prompt _prompt;
    [SerializeField] private string _promptText;
    [SerializeField] private AudioClip _audioClip;
    
    protected override void Click()
    {
        ShowPrompt();
        AudioActions.PlaySound(_audioClip);
    }

    private void ShowPrompt()
    {
        _prompt.SetPrompt(_promptText, LoadMenuScene, DenyCallback);
    }

    private void DenyCallback()
    {
        _prompt.Hide();
    }

    private void LoadMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }
}
