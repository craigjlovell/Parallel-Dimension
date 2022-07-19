using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CipherScript : MonoBehaviour
{
    public string[] words = new string[1] { "trippy"};
    public List<int> number = new List<int>();

    public string code = "test";

    public TextMeshProUGUI inputs;
    public bool fire = false;

    // Update is called once per frame
    void Update()
    {
        KeyPressed();

        if (code != "test")
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (code == words[i].ToString())
                {
                    print("you win");
                }
            }
        }
        
    }

    public void KeyPressed()
    {
        foreach (char c in Input.inputString)
        {
            if (c == '\b') // has backspace/delete been pressed?
            {
                if (inputs.text.Length != 0)
                {
                    inputs.text = inputs.text.Substring(0, inputs.text.Length - 1);
                }
            }
            else if ((c == '\n') || (c == '\r')) // enter/return
            {
                print("User entered their name: " + inputs.text);
            }
            else
            {
                char letterT = Input.inputString[0];
                int numT = (int)letterT;
                inputs.text += c;
                numT = numT - 97;
                number.Add(numT);
            }

            
            
            //inputs.text += Input.inputString;            
            //print(numT);
        }        
    }

    public void Save()
    {
        code = inputs.text;
        fire = true;
        for (int i = 0; i < number.Count; i++)
        {
            print(number[i]);
        }        
    }
}
