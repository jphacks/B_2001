using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Read_month : MonoBehaviour
{
    // Dropdownを格納する変数
    [SerializeField] private Dropdown dropdown;

    // 状態の把握
        public int SC_Add_Month()
        {
            // Dropdownの数値を確認
            return dropdown.value;

        }
}
