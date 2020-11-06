using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Schedule_Display : MonoBehaviour
{
    private Text Stext;


    void Start()
    {
        Stext = GetComponentInChildren<Text>();
    }

    
    void Update()
    {
        if (ScheduleView.monthd == DateTime.Now.Month && ScheduleView.dayd == DateTime.Now.Day)
        {
            Stext.text = ScheduleView.monthd + "月" + ScheduleView.dayd + "日\n" + "予定:" + ScheduleView.scheduled;
        }
        else
        {
            Stext.text = "今日は一日自由だ！";
        }
    }
}
