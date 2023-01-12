using System.Collections;
using TMPro;
using UnityEngine;

public class AnswerButton : AbstractButton
{
    [SerializeField] private TMP_Text _label;

    [SerializeField] private AudioClip _correctAnswerSound;
    [SerializeField] private AudioClip _wrongAnswerSound;

    private GameManager _gameManager;

    public bool isTaken;
    public bool isCorrectAnswer;

    public void SetButtonLabel(int value)
    {
        _label.text = value.ToString();
        isTaken = true;
    }

    protected override void Click()
    {
        CheckAnswer();
        PlaySound();
    }

    private void PlaySound()
    {
        AudioActions.PlaySound(isCorrectAnswer ? _correctAnswerSound : _wrongAnswerSound);
    }

    private void CheckAnswer()
    {
        StartCoroutine(isCorrectAnswer ? ShowCorrectAnswer() : ShowWrongAnswer());
    }

    private IEnumerator ShowCorrectAnswer()
    {
        GameActions.CorrectAnswer();
        GameActions.LockButtons();
        GameActions.AddGoodAnswerToCounter();
        yield return new WaitForSeconds(1);
        LoadNextStep();
    }

    private IEnumerator ShowWrongAnswer()
    {
        GameActions.WrongAnswer();
        GameActions.LockButtons();
        GameActions.AddWrongAnswerToCounter();
        yield return new WaitForSeconds(1);
        LoadNextStep();
    }

    private void LoadNextStep()
    {
        GameManager.Instance.LoadNextEquation();

        if (GameManager.Instance.IsPlaying)
        {
            GameActions.UnlockButtons();
        }
    }
}
