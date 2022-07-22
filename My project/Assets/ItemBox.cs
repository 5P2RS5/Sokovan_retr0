using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    Renderer myRenderer;
    public bool isOverrapped = false;
    
    public Color touchColor;
    Color originalColor;
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
        originalColor = myRenderer.material.color;
    }
    
    // Enter = 충돌 한 순간
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOverrapped = true;
            myRenderer.material.color = touchColor;
        }
    }

    // 충돌 벗어날 때
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOverrapped = false;
            myRenderer.material.color = originalColor;
        }
    }
    // 충돌하고 있는 공안
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "EndPoint")
        {
            isOverrapped = true;
            myRenderer.material.color = touchColor;
        }
    }
    
}
