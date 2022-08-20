using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FlipMeat : MonoBehaviour
{
    public static bool isFornt = true;
    public bool onOff = false;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            onOff = true;
        }
    }

    public void OnMouseEnter()
    {
        onOff = false;
        Debug.Log("Fornt");
    }


}
