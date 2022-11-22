using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneButton : AbstractButton
{
    [SerializeField] private string _sceneName;
    protected override void Click()
    {
        SceneManager.LoadScene(_sceneName);
        base.Click();
    }
}
