using System;
using TMPro;
using UnityEngine;

public class FinishPanel : MonoBehaviour
{
    [SerializeField] private TMP_Text _goodAnswersText;
    [SerializeField] private TMP_Text _wrongAnswersText;

    [Header("Audio")] 
    [SerializeField] private AudioClip _finishedGameSound;
    private void OnEnable()
    {
        AudioActions.PlaySound(_finishedGameSound);
    }

    public void SetFinishPanelDetails(int goodAnswers, int wrongAnswers)
    {
        _goodAnswersText.text = goodAnswers.ToString();
        _wrongAnswersText.text = wrongAnswers.ToString();
    }
}
