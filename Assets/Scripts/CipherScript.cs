using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CipherScript : MonoBehaviour
{
    public string[] words = new string[] { "Trippy", };
    
    public TextMeshProUGUI Inputs;

    // Update is called once per frame
    void Update()
    {
        KeyPressed();        
    }

    public void KeyPressed()
    {
        char letterT = Input.inputString[0];
        int numT = (int)letterT;
        Inputs.text += Input.inputString;
        print(numT - 97);
    }
}
