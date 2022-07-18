using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimonSays : MonoBehaviour
{
    public ButtonSettings[] gameButtons;

    public float[] seq1 = new float[1] { 2 };
    public float[] seq2 = new float[2] { 2, 0 };
    public float[] seq3 = new float[3] { 2, 0, 1 };
    public float[] seq4 = new float[4] { 2, 0, 1, 3 };

    public float[] safeCode = { 2, 0, 1, 3 };

    // Start is called before the first frame update
    void Start()
    {
        gameButtons[4] = new ButtonSettings();

        for (int i = 0; i < gameButtons.Length; i++)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ButtonCreating(int index, Vector3 position)
    {

    }

    public void SaysButtonPressed(int index)
    {
    }

    public void GameOver()
    {
    }
}
