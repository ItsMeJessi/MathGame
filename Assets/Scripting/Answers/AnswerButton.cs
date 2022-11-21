using TMPro;
using UnityEngine;

public class AnswerButton : AbstractButton
{
    [SerializeField] private TMP_Text _label;

    private GameManager GameManager;

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
            GameManager.Instance.LoadNextEquation();
        }
    }
}
