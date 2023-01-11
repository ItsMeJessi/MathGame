using UnityEngine;

public class PromptButton : AbstractButton
{
    [SerializeField] private AudioClip _audioClip;

    protected override void Click()
    {
        AudioActions.PlaySound(_audioClip);
    }
}
