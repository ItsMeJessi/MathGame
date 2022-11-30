using UnityEngine.SceneManagement;

public class ExitToMenuButton : AbstractButton
{
    protected override void Click()
    {
        ShowPrompt();
        base.Click();
    }

    private void ShowPrompt()
    {
        
    }

    private void LoadMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }
}
