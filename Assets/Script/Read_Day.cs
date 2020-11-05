using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Read_Day : MonoBehaviour
{
    // Dropdownを格納する変数
    [SerializeField] private Dropdown dropdown;

    public static int dayv;


    void Update()
    {
        dayv = dropdown.value;
    }

}
