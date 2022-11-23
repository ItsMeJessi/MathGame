using UnityEngine;

public class OpenPanel : AbstractButton
{
    [SerializeField] private GameObject _currentPanel;
    [SerializeField] private GameObject _panelToOpen;

    protected override void Click()
    {
        SwitchPanels();
        base.Click();
    }

    private void SwitchPanels()
    {
        _currentPanel.SetActive(false);
        _panelToOpen.SetActive(true);
    }
}
