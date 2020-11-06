using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alarm_H : MonoBehaviour
{
    //現在の「時」を格納する変数
    private string time;
    //現在の「分」を格納する変数
    private string m_time;

    //0時に設定しないように
    public static int iptime = 25;
    //「時」の設定用の変数
    int new_set_time;
    //「分」の設定用の変数
    int m_settime;

    //変数timeをint型に変換するための変数
    int newtime;
    //変数m_timeをint型に変換するための変数
    int m_newtime;

    //if文用
    int k = 1;

    private AudioSource audioSource;

    [SerializeField] private Dropdown dropdownComponent;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    public void GetValue()
    {
        //ドロップダウンの値を入れる
        iptime = dropdownComponent.value;
        Debug.Log(iptime);
        //Alarm_set()に渡す
        Alarm_set(iptime);
    }
    public void Alarm_set(int set_time)
    {
        //渡されたドロップダウンの値を格納
        new_set_time = set_time;
        //スクリプト「Alarm_M」の変数「iptime_2」を格納
        m_settime = Alarm_M.iptime_m2;

    }
    void Update()
    {
        //現在の「時」を取得
        time = System.DateTime.Now.Hour.ToString();
        //string型からint型に変換
        newtime = int.Parse(time);

        //現在の「分を取得」
        m_time = System.DateTime.Now.Minute.ToString();
        //string型からint型に変換
        m_newtime = int.Parse(m_time);

        //設定した時間が現在時刻と同じなら○○をする
        if (new_set_time == newtime && m_settime == m_newtime && k == 1)
        {
            Debug.Log("Alarm");
            audioSource.Play();
            Debug.Log("Alarm2");
            k = 2;

        }
        if (k == 2 && Input.GetMouseButtonDown(2))
        {
            audioSource.Stop();
        }
    }
}