using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxChange : MonoBehaviour
{
    //事前にInspectorから設定した、Skyboxのマテリアル
    public Material skybox;
    public Material skybox2;
    public Material skybox3;
    // Start is called before the first frame update
    void Start()
    {
        //skyboxの変更
        RenderSettings.skybox = skybox;
    }

    // Update is called once per frame
    void Update()
    {
        //右クリックを押すとskybox2に入っている背景に切り替わる
        if (Input.GetMouseButtonDown(1)){
            RenderSettings.skybox = skybox2;
        }

        //左クリックを押すとskybox2に入っている背景に切り替わる
        else if (Input.GetMouseButtonDown(0)) {
            RenderSettings.skybox = skybox3;
        }


    }
}
