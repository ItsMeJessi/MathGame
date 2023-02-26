using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsUI : MonoBehaviour
{
    [SerializeField] private Slider _musicSlider;
    [SerializeField] private Slider _sfxSlider;

    [SerializeField] private AudioMixer _musicMixer;
    [SerializeField] private AudioMixer _sfxMixer;

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
        _musicMixer.SetFloat("MusicVolume", math.log10(_musicSlider.value) * 20);
    }

    private void SetSfxValue()
    {
        _sfxMixer.SetFloat("SfxVolume", math.log10(_sfxSlider.value) * 20);
    }
}
