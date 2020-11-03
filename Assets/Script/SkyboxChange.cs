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
        time = System.DateTime.Now.Hour.ToString();
        int newtime = int.Parse(time);

        //4時から11時まではskybox1の背景
        if (newtime >= 4 && newtime <= 11)
        {
            RenderSettings.skybox = skybox1;
        }

        //12時から18時まではskybox1の背景
        else if (newtime >= 12 && newtime <= 18)
        {
            RenderSettings.skybox = skybox2;
        }
        //19時から3時まではskybox1の背景
        else if (newtime >= 19 && newtime <= 24 || newtime >= 0 && newtime <= 3)
        {
            RenderSettings.skybox = skybox3;
        }

    }
}
