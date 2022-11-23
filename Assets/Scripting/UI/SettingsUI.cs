using System;
using UnityEngine;
using UnityEngine.UI;

public class SettingsUI : MonoBehaviour
{
    [SerializeField] private Slider _musicSlider;
    [SerializeField] private Slider _sfxSlider;

    private void OnEnable()
    {
        _musicSlider.onValueChanged.AddListener( delegate { SetMusicValue(); });
        _sfxSlider.onValueChanged.AddListener(delegate{ SetSfxValue(); });
    }

    private void OnDisable()
    {
        _musicSlider.onValueChanged.RemoveAllListeners();
    }

    private void SetMusicValue()
    {
        //todo: audio level set to value
    }

    private void SetSfxValue()
    {
        //todo: sfx level set to value
    }
}
