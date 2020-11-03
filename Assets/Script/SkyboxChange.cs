using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class SkyboxChange : MonoBehaviour
{
    //事前にInspectorから設定した、Skyboxのマテリアル
    public Material skybox1;
    public Material skybox2;
    public Material skybox3;
    public Material skybox4;

    //判定用変数
    private bool a = false;
    private bool b = false;
    private bool c = false;
    private bool d = false;

    //時間を取得
    private string time;
    // Start is called before the first frame update
    void Start()
    {
        //skyboxの変更
        RenderSettings.skybox = skybox1;
    }

    // Update is called once per frame
    void Update()
    {
        //a,b,c,dがtrueならfalseに変換
        if (a && b && c && d)
        {
            a = false;
            b = false;
            c = false;
            d = false;
        }

        time = System.DateTime.Now.Hour.ToString();
        int newtime = int.Parse(time);

        //4時から11時まではskybox1の背景
        if (newtime >= 4 && newtime <= 11)
        {
            if (!a)
            {
                RenderSettings.skybox = skybox1;
                a = true;
            }
            else
            {
            }
        }

        //12時から15時まではskybox1の背景
        else if (newtime >= 12 && newtime <= 15)
        {
            if (!b)
            {
                RenderSettings.skybox = skybox2;
                b = true;
            }
            else
            {
            }
        }
        //16時から18時まではskybox1の背景
        else if (newtime >= 16 && newtime <= 18)
        {
            if (!c)
            {
                RenderSettings.skybox = skybox3;
                c = true;
            }
            else
            {
            }
        }
        //19時から3時まではskybox1の背景
        else if (newtime >= 19 && newtime <= 24 || newtime >= 0 && newtime <= 3)
        {
            if (!d)
            {
                RenderSettings.skybox = skybox4;
                d = true;
            }
            else
            {
            }
        }
    }
}
