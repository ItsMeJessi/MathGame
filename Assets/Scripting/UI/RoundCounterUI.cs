using System;
using TMPro;
using UnityEngine;

public class RoundCounterUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _roundCounterText;

    private void OnEnable()
    {
        BindEvents();
    }

    private void OnDisable()
    {
        UnbindFromEvents();
    }

    private void BindEvents()
    {
        GameActions.UpdateRoundCounter += UpdateCounterUI;
    }

    private void UnbindFromEvents()
    {
        GameActions.UpdateRoundCounter += UpdateCounterUI;
    }

    private void UpdateCounterUI(int round)
    {
        _roundCounterText.text = $"{round}/10";
    }
}
