using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeController : MonoBehaviour
{
    public TMPro.TextMeshProUGUI text;

    public int ButtonValue0;
    public int ButtonValue1;
    public int ButtonValue2;
    public int ButtonValue3;
    


    public void InputButton(int PIN)
    {
        if (text.text.Length < 4)
        {
            text.text += PIN;
        }
    }

    public void Backspace()
    {
        text.text = "";
    }

    public void Enter()
    {

    }
}
