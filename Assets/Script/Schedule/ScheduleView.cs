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
        public int day;
        public string schedule;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(JsonUtility.ToJson(this));
    }

    // Update is called once per frame
    void Update()
    {
        todays_schedule abc = loadToday();
        Debug.Log(abc);
    }
    
    // JSONから読み込む
    public todays_schedule loadToday()
    {
        string datastr = "";
        StreamReader reader;
        reader = new StreamReader(Application.dataPath + "json/schedule.json");
        datastr = reader.ReadToEnd();
        reader.Close();

        return JsonUtility.FromJson<todays_schedule>(datastr);
    }

    // JSONに書き込む
    public void writetoday(todays_schedule schedule)
    {
        StreamWriter writer;

        string jsonstr = JsonUtility.ToJson(schedule);

        writer = new StreamWriter(Application.dataPath + "json/schedule.json", false);
        writer.Write(jsonstr);
        writer.Flush();
        writer.Close();
    }

}
