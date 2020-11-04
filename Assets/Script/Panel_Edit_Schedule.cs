using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Panel_Edit_Schedule : MonoBehaviour, IPointerClickHandler
{

    [SerializeField]
    GameObject panel;

    // クリックされたらパネルをvisibleに
    public void OnPointerClick(PointerEventData eventData)
    {
        panel.SetActive(true);
    }
}
