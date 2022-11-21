using TMPro;
using UnityEngine;

public class AnswerButton : MonoBehaviour
{
    [SerializeField] private TMP_Text _label;

    public bool isTaken;
    public bool isCorrectAnswer;
    public void SetButtonLabel(int value)
    {
        _label.text = value.ToString();
        isTaken = true;
    }

    public void CheckAnswer()
    {
        Debug.Log(isCorrectAnswer);
    }
}
