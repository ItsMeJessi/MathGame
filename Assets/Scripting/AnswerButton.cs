using TMPro;
using UnityEngine;

public class AnswerButton : MonoBehaviour
{
    [SerializeField] private TMP_Text _label;

    public void SetButtonLabel(int value)
    {
        _label.text = value.ToString();
    }
}
