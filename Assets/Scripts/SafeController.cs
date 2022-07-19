using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeController : MonoBehaviour
{
    public TMPro.TextMeshProUGUI text;

    public int buttonValue0;
    public int buttonValue1;
    public int buttonValue2;
    public int buttonValue3;
    public int[] simonCode = new int[4];
    public int[] codeCypher = new int[4];
    public SimonSays2 simonSays;
    public int index = 0;
    public int trueCheck;


    public void InputButton(int PIN)
    {
        if (text.text.Length < 4)
        {
            text.text += PIN;
            simonCode[index] = PIN;
            index++;
        }

    }

    public void Backspace()
    {
        text.text = "";
        index = 0;
    }

    public void Enter()
    {
        for (int i = 0; i < codeCypher.Length; i++)
        {
            if (simonSays.Sequence[i] == 0)
            {
                codeCypher[i] = buttonValue0;
            }
            else if (simonSays.Sequence[i] == 1)
            {
                codeCypher[i] = buttonValue1;
            }
            else if (simonSays.Sequence[0] == 2)
            {
                codeCypher[i] = buttonValue2;
            }
            else if (simonSays.Sequence[1] == 3)
            {
                codeCypher[i] = buttonValue3;
            }
        }

        trueCheck = 0;
        for(int i = 0; i < simonCode.Length-1; i++)
        {
            if (!simonCode[i].Equals(simonSays.Sequence[i]))
            {
                Debug.Log("lose");
            }
            else
            {
                trueCheck++;
            }
        }
        if (trueCheck == 3)
        {
            Debug.Log("win");
            text.text = "";
        }
        else
        {
            trueCheck = 0;
        }
    }
}
