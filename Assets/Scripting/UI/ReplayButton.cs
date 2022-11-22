using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayButton : AbstractButton
{
    protected override void Click()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        base.Click();
    }
}
