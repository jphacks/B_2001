using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time_G : MonoBehaviour
{
    int m;
    int t;
    private Text timetext;
    // Start is called before the first frame update
    void Start()
    {
        t = Alarm_H.iptime;
        m = Alarm_M.iptime_m2;
        timetext = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timetext.text = t + ":" + m;
    }
}
