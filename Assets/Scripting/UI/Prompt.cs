using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Prompt : MonoBehaviour
{
    [SerializeField] private TMP_Text _promptText;
    [SerializeField] private AbstractButton _confirmButton;
    [SerializeField] private AbstractButton _denyButton;

    [SerializeField] private GameObject _gameplayUI;

    public delegate void ConfirmCallback();

    public event ConfirmCallback ConfirmCallbackEvent;

    public delegate void DenyCallback();

    public event DenyCallback DenyCallbackEvent;

    public void SetPrompt(string promptText, ConfirmCallback confirmCallback, DenyCallback denyCallback)
    {
        _promptText.text = promptText;
        _confirmButton.GetComponent<Button>().onClick.AddListener(() => confirmCallback());
        _denyButton.GetComponent<Button>().onClick.AddListener(() => denyCallback());
        
        Show();
    }

    private void Show()
    {
        _gameplayUI.SetActive(false);
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false); 
        _gameplayUI.SetActive(true);
    }
}