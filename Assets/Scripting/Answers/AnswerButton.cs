using System.Collections;
using TMPro;
using UnityEngine;

public class AnswerButton : AbstractButton
{
    [SerializeField] private TMP_Text _label;

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
        base.Click();
    }

    private void CheckAnswer()
    {
        if (isCorrectAnswer)
        {
            StartCoroutine(ShowCorrectAnswer());
        }
        else
        {
            StartCoroutine(ShowWrongAnswer());
        }
    }

    private IEnumerator ShowCorrectAnswer()
    {
        GameActions.CorrectAnswer();
        GameActions.LockButtons();
        yield return new WaitForSeconds(1);
        GameManager.Instance.LoadNextEquation();
        GameActions.UnlockButtons();
    }

    private IEnumerator ShowWrongAnswer()
    {
        GameActions.WrongAnswer();
        GameActions.LockButtons();
        yield return new WaitForSeconds(1);
        GameManager.Instance.LoadNextEquation();
        GameActions.UnlockButtons();
    }
}
