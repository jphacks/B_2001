using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Get_Inf : MonoBehaviour
{
 
    public Serial_Master serial_Master;
    public Text text;


  void Start()
    {
        serial_Master.DataReceive += DataReceive;
    }

    void Update()
    {

    }

    // 受け取ったら
    void DataReceive(string message)
    {
   
        try
        {
            float atm = float.Parse(message);
            if (atm < 1013.00)
            {
                text.text = "atm: " + atm + "[hPa]" + "\n今日は" + "低気圧" + "だよ！";
            }
            else
            {
                text.text = "atm: " + atm + "[hPa]";
            }

        }
        catch (System.Exception e)
        {
            Debug.LogWarning(e.Message);
        }
    }
}

