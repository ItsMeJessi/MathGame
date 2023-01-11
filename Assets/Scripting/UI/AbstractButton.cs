using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public abstract class AbstractButton : MonoBehaviour
 {
    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    protected virtual void OnEnable()
    {
        _button.onClick.AddListener(Click);
    }
    
    protected virtual void OnDisable()
    {
        _button.onClick.RemoveAllListeners();
    }

    protected virtual void Click()
    {
        
    }

    protected void LockButton()
    {
        _button.interactable = false;
    }

    protected void UnlockButton()
    {
        _button.interactable = true;
    }
}
