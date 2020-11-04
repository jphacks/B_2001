using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm_m : MonoBehaviour
{
    private string minute;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        minute = System.DateTime.Now.Minute.ToString();
    }
}
