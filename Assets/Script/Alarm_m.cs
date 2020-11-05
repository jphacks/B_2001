using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alarm_M : MonoBehaviour
{
    public static int iptime_m2;

    [SerializeField] private Dropdown dropdownComponent;

    void Start()
    {

    }

    public void Get_m_time()
    {
        //ドロップダウンの値を格納（分用）
        iptime_m2 = dropdownComponent.value;
        Debug.Log(iptime_m2);


    }

}

