using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public Text text;

    private void Update()
    {
        text.text = $"점수: {Score.value}점";
    }
}
