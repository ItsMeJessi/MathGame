using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _givenNumberText;
    [SerializeField] private TMP_Text _resultNumberText;
    [SerializeField] private TMP_Text _missingNumberText;

    private static readonly Color32 GoodAnswerColor = new(212, 255, 67, 255);
    private static readonly Color32 DefaultColor = Color.white;

    public void SetGivenNumberText(int value)
    {
        _givenNumberText.text = value.ToString();
    }

    public void SetResultNumberText(int value)
    {
        _resultNumberText.text = value.ToString();
    }

    public void SetMissingNumberText(int value)
    {
        _missingNumberText.color = GoodAnswerColor;
        _missingNumberText.text = value.ToString();
    }

    public void ResetMissingNumberToQuestionMark()
    {
        _missingNumberText.color = DefaultColor;
        _missingNumberText.text = "?";
    }
}
