using UnityEngine;

public class ClosePanel : AbstractButton
{
    [SerializeField] private GameObject _currentPanel;

    protected override void Click()
    {
        Close();
        base.Click();
    }

    private void Close()
    {
        _currentPanel.SetActive(false);
    }
}
