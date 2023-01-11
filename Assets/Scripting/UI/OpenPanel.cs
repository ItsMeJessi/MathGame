using UnityEngine;

public class OpenPanel : AbstractButton
{
    [SerializeField] private GameObject _currentPanel;
    [SerializeField] private GameObject _panelToOpen;
    [SerializeField] private AudioClip _clickSound;

    protected override void Click()
    {
        SwitchPanels();
        AudioActions.PlaySound(_clickSound);
    }

    private void SwitchPanels()
    {
        _currentPanel.SetActive(false);
        _panelToOpen.SetActive(true);
    }
}
