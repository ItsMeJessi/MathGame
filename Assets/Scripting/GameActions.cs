using System;
using UnityEngine;

public static class GameActions
{
    public static Action CorrectAnswer;
    public static Action WrongAnswer;
    public static Action GeneratorReset;

    public static Action LockButtons;
    public static Action UnlockButtons;

    public static Action<int> UpdateRoundCounter;

    public static Action AddGoodAnswerToCounter;
    public static Action AddWrongAnswerToCounter;

    public static Action<int> SetDifficultyLevel;
}

public static class AudioActions
{
    public static Action<AudioClip> PlaySound;
}
