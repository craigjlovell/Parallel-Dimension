using UnityEngine;
using System;
using System.Collections;

[Serializable]
public class ButtonSettings : MonoBehaviour
{
    public Color normalColor;
    public Color highlightColor;

    float resetDelay = .25f;

    private void Start()
    {
        ResetButton();
    }

    public void OnMouseDown()
    {
        GetComponent<MeshRenderer>().material.color = highlightColor;
        Invoke("ResetButton", resetDelay);
    }

    public void ResetButton()
    {
        GetComponent<MeshRenderer>().material.color = normalColor;
    }
}