using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Read_Schedule : MonoBehaviour
{
    // 入力フォームと結び付け
    public InputField inputField;

    // スケジュールを格納する変数
    public static string schedulev;

    void Start()
    {
        // 入力フォームを探す
        inputField = GameObject.Find("Input_Schedule").GetComponent<InputField>();
    }

    
    void Update()
    {
        // スケジュールを格納
        string schedulev = inputField.text;
    }
}

