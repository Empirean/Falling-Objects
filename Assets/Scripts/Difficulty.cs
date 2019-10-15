using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Difficulty  {

    static float secondsToMaxDIfficulty = 60;

    public static float GetDifficultyPercent()
    {
        return Mathf.Clamp(Time.time / secondsToMaxDIfficulty, 0, 1);
    }
}
