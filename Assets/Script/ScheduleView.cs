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
        
    }
}
