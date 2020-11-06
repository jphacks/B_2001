using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;



public class ScheduleView : MonoBehaviour
{

    // スケジュールのオブジェクト
    [System.Serializable]
    public class todays_schedule
    {
        public int month;
        public int day;
        public string schedule;
    }
    

    void Start()
    {
        //Debug.Log(JsonUtility.ToJson(this));
    }


    void Update()
    {
        todays_schedule today_re = loadToday();
        Debug.Log(today_re);
    }
    
    // JSONから読み込む
    public todays_schedule loadToday()
    {
        string datastr = "";
        StreamReader reader;
        reader = new StreamReader(Application.dataPath + "/json/schedule.json");
        datastr = reader.ReadToEnd();
        reader.Close();

        return JsonUtility.FromJson<todays_schedule>(datastr);
    }



}
