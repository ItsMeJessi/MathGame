using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _givenNumberText;
    [SerializeField] private TMP_Text _resultNumberText;
    [SerializeField] private TMP_Text _missingNumberText;

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
        _missingNumberText.color = new Color32(212, 255, 67, 255);
        _missingNumberText.text = value.ToString();
    }

    public void ResetMissingNumberToQuestionMark()
    {
        _missingNumberText.color = Color.white;
        _missingNumberText.text = "?";
    }
}
