/****************************************
*   Submit_Schedules.cs                 *
*****************************************
*   Submitボタンが押されたら、Json      *
*   にすけーじゅるが書き込まれる        *
*****************************************
*   int dayv : 日                       *
*   int monthv : 月                     *
*   string schedulev : 内容             *
****************************************/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class Submit_Schedule : MonoBehaviour
{

    // スケジュールのオブジェクト
    [System.Serializable]
    public class todays_schedule
    {
        public int month;
        public int day;
        public string schedule;
    }

    // スケジュールのオブジェクト
    [System.Serializable]
    public class todays_schedule_allay
    {
        public todays_schedule[] tallay;
    }

    public void OnClick()
    {
        /*
        // 月、日、予定の取得
        todays_schedule_allay schedules_master = new todays_schedule_allay()
        {
            tallay = new todays_schedule[]
            {
                new todays_schedule()
                {
                    todays_Schedule.day = Read_Day.dayv,
                    todays_Schedule.month = Read_month.monthv,
                    todays_Schedule.schedule = Read_Schedule.schedulev,
                }
            }
        };
        // 書き込み
        writetoday(todays_Schedule);
        */
   
    }

    // JSONに書き込む
    public void writetoday(todays_schedule todays_Schedule)
    {
        StreamWriter writer;

        // JSONへ変換
        string jsonsh = JsonUtility.ToJson(todays_Schedule);
        Debug.Log(jsonsh);

        writer = new StreamWriter(Application.dataPath + "/json/schedule.json", false);
        writer.Write(jsonsh);
        writer.Flush();
        writer.Close();
    }
}
