using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimonSays2 : MonoBehaviour
{
    public int[] Sequence = new int[4] {0,3,1,2};
    public int[] Says = new int[4];
    public int length;
    public int desiredLength;

    public ButtonSettings[] buttons = new ButtonSettings[4];

    private void Start()
    {
        Sequence = new int[4] { Random.Range(0, 3), Random.Range(0, 3), Random.Range(0, 3), Random.Range(0, 3) };
        length = 0;
        desiredLength = 0;
        StartCoroutine(ShowSequence());
    }

    public void ButtonPressed(int index)
    {
        if (index == Sequence[length])
        {
            if (length != desiredLength)
            {
                length++;                
            }
            else if (desiredLength < 3)
            {
                length = 0;
                desiredLength++;
                StartCoroutine(ShowSequence());
            }
            else
            {
                length = 0;
                desiredLength = 0;
                //complete
            }
        }
        else
        {
            Sequence = new int[4] { Random.Range(0, 3), Random.Range(0, 3), Random.Range(0, 3), Random.Range(0, 3) };
            length = 0;
            desiredLength = 0;
            StartCoroutine(ShowSequence());
        }
    }

    IEnumerator ShowSequence()
    {
        //yield return new WaitForSeconds(buttons[Sequence[0]].resetDelay * 2);
        //buttons[Sequence[0]].LightUpButton();
        //if (desiredLength >= 1)
        //{
        //    yield return new WaitForSeconds(buttons[Sequence[0]].resetDelay*2);
        //    buttons[Sequence[1]].LightUpButton();
        //}
        //if (desiredLength >= 2)
        //{
        //    yield return new WaitForSeconds(buttons[Sequence[1]].resetDelay*2);
        //    buttons[Sequence[2]].LightUpButton();
        //}
        //if (desiredLength >= 3)
        //{
        //    yield return new WaitForSeconds(buttons[Sequence[2]].resetDelay*2);
        //    buttons[Sequence[3]].LightUpButton();
        //}

        for (int i = 0; i < 4; i++)
        {
            if (desiredLength >= i)
            {
                yield return new WaitForSeconds(buttons[Sequence[i]].resetDelay * 2);
                buttons[Sequence[i]].LightUpButton();
            }
        }
    }
}
