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
    private int a;

    void Start()
    {
        //Componentを扱えるようにする
        inputField = inputField.GetComponent<InputField>();
        text = text.GetComponent<Text>();

    }

    public void InputText()
    {
        //テキストにinputFieldの内容を反映
        text.text = inputField.text;
        

    }
    // Update is called once per frame
    void Update()
    {
        newtext = text.text;
        int a = int.Parse(newtext);
        if (a == 1)
        {
            text.text = "aaa";
            text.text = inputField.text;
        }
    }
}


