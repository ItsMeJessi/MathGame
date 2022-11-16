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
        _missingNumberText.text = value.ToString();
    }
}
