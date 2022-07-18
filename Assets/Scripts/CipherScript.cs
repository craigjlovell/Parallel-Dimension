using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CipherScript : MonoBehaviour
{
    public string[] letters = new string[26] {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};

    public Text Inputs;
    public int numberLength;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Inputs.text = Inputs.text + "1";
            numberLength = 1;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            Inputs.text = Inputs.text + "2";
            numberLength = 1;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Inputs.text = Inputs.text + "3";
            numberLength = 1;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Inputs.text = Inputs.text + "4";
            numberLength = 1;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            Inputs.text = Inputs.text + "5";
            numberLength = 1;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Inputs.text = Inputs.text + "6";
            numberLength = 1;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            Inputs.text = Inputs.text + "7";
            numberLength = 1;
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            Inputs.text = Inputs.text + "8";
            numberLength = 1;
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            Inputs.text = Inputs.text + "9";
            numberLength = 1;
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            Inputs.text = Inputs.text + "10";
            numberLength = 2;
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            Inputs.text = Inputs.text + "11";
            numberLength = 2;
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Inputs.text = Inputs.text + "12";
            numberLength = 2;
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            Inputs.text = Inputs.text + "13";
            numberLength = 2;
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            Inputs.text = Inputs.text + "14";
            numberLength = 2;
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            Inputs.text = Inputs.text + "15";
            numberLength = 2;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            Inputs.text = Inputs.text + "16";
            numberLength = 2;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Inputs.text = Inputs.text + "17";
            numberLength = 2;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Inputs.text = Inputs.text + "18";
            numberLength = 2;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Inputs.text = Inputs.text + "19";
            numberLength = 2;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            Inputs.text = Inputs.text + "20";
            numberLength = 2;
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            Inputs.text = Inputs.text + "21";
            numberLength = 2;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            Inputs.text = Inputs.text + "22";
            numberLength = 2;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Inputs.text = Inputs.text + "23";
            numberLength = 2;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            Inputs.text = Inputs.text + "24";
            numberLength = 2;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            Inputs.text = Inputs.text + "25";
            numberLength = 2;
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Inputs.text = Inputs.text + "26";
            numberLength = 2;
        }

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            Inputs.text = "";
        }
    }
}
