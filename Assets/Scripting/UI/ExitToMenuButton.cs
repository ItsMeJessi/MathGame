using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitToMenuButton : AbstractButton
{
    [SerializeField] private Prompt _prompt;
    [SerializeField] private string _promptText;
    
    protected override void Click()
    {
        ShowPrompt();
        base.Click();
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
