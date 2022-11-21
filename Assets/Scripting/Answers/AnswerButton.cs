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
        StartCoroutine(isCorrectAnswer ? ShowCorrectAnswer() : ShowWrongAnswer());
    }

    private IEnumerator ShowCorrectAnswer()
    {
        GameActions.CorrectAnswer();
        GameActions.LockButtons();
        yield return new WaitForSeconds(1);
        LoadNextStep();
    }

    private IEnumerator ShowWrongAnswer()
    {
        GameActions.WrongAnswer();
        GameActions.LockButtons();
        yield return new WaitForSeconds(1);
        LoadNextStep();
    }

    private void LoadNextStep()
    {
        GameManager.Instance.LoadNextEquation();
        GameActions.UnlockButtons();
    }
}
