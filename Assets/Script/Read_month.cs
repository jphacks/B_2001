﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Read_month : MonoBehaviour
{
    // Dropdownを格納する変数
    [SerializeField] private Dropdown dropdown;

    public static int monthv;


    void Update()
    {
        monthv = 1+dropdown.value;
    }

}
