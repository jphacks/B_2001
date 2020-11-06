using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Start_image : MonoBehaviour
{
    private int random;
    //Gameobjcet設定
    [SerializeField] private GameObject a;
    [SerializeField] private GameObject b;
    [SerializeField] private GameObject c;




    void Start()
    {
        //画像をすべて非表示
        a.SetActive(false);
        b.SetActive(false);
        c.SetActive(false);
        //1～3までの乱数を表示
        random = Random.Range(1, 4);

        switch (random)
        {
            //randomが1の時
            case 1:
                a.SetActive(true);

                break;

            //randomが2の時
            case 2:
                b.SetActive(true);

                break;

            //randomが3の時
            case 3:
                c.SetActive(true);

                break;
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
        }
    }
}