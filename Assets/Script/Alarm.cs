using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alarm : MonoBehaviour
{

    //オブジェクトと結びつける
    public InputField inputField;
    public Text text;
    private string newtext;
    private string time;

    void Start()
    {
        //Componentを扱えるようにする
        inputField = inputField.GetComponent<InputField>();
        text = text.GetComponent<Text>();

    }

    public void InputText()
    {
        newtext = inputField.text;
        int a = int.Parse(newtext);

        time = System.DateTime.Now.Hour.ToString();
        int newtime = int.Parse(time);

        //テキストにinputFieldの内容を反映
        text.text = inputField.text;
        if (a == newtime)
        {
            text.text = "123";
        }

    }

}