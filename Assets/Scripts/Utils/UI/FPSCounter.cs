using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// FPS計測
/// </summary>
public class FPSCounter : MonoBehaviour
{
    /// <summary>
    /// 表示用テキスト
    /// </summary>
    private Text DisplayText = null;

    protected void Awake()
    {
        DisplayText = GetComponent<Text>();
    }

    protected void Update()
    {
        int FPS = (int)(1.0f / Time.deltaTime);
        Color TextColor = Color.blue;
        if(FPS <= 10)
        {
            TextColor = Color.red;
        }
        else if(FPS <= 20)
        {
            TextColor = Color.yellow;
        }
        DisplayText.text = "FPS:" + FPS;
        DisplayText.color = TextColor;
    }
}
