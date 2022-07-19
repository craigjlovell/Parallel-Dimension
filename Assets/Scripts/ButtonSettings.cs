using UnityEngine;
using System;
using System.Collections;

[Serializable]
public class ButtonSettings : MonoBehaviour
{
    public Color normalColor;
    public Color highlightColor;
    public int index;

    public float resetDelay = .25f;

    [SerializeField] private SimonSays2 simonSays; 

    private void Start()
    {
        ResetButton();
    }

    public void OnMouseDown()
    {
        simonSays.ButtonPressed(index);
        LightUpButton();
    }

    public void LightUpButton()
    {
        GetComponent<MeshRenderer>().material.color = highlightColor;
        Invoke("ResetButton", resetDelay);
    }

    public void ResetButton()
    {
        GetComponent<MeshRenderer>().material.color = normalColor;
    }
}