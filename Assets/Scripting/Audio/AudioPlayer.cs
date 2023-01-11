using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioPlayer : MonoBehaviour
{
    private AudioSource _audioSource;
    public static AudioPlayer Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
        
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        AudioActions.PlaySound += PlaySound;
    }

    private void OnDisable()
    {
        AudioActions.PlaySound -= PlaySound;
    }

    private void PlaySound(AudioClip audioClip)
    {
        _audioSource.PlayOneShot(audioClip);
    }
}
