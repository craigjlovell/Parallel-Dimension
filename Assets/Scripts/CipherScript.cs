using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CipherScript : MonoBehaviour
{
    [SerializeField] private string[] words = new string[5] { "trippy", "dreaming", "puzzle", "ethereal", "liminal" };

    [SerializeField] private string codeAnswer;
    [SerializeField] private string codeTry = "filler";

    [SerializeField] private List<int> noteNum = new List<int>();
    string notes;

    public List<int> number = new List<int>();

    public int trys = 3; 

    public TextMeshProUGUI inputs;
    public TextMeshProUGUI CodeHint;
    public bool fire = false;

    private void Start()
    {
        codeAnswer = words[Random.Range(0,5)];
        notes = codeAnswer;

        if (noteNum.Count < notes.Length)
        {
            for (int i = 0; i < notes.Length; i++)
            {
                noteNum.Add((int)notes[i] - 'a');
            }
        }
        for (int i = 0;i < noteNum.Count; i++)
        {
            CodeHint.text += noteNum[i] + " ";
        }
    }

    // Update is called once per frame
    private void Update()
    {
        KeyPressed();
        

        notes = codeAnswer;
        if (trys > 0)
        {            
            if (codeTry != "filler")
            {
                for (int i = 0; i < 5; i++)
                {
                    if (codeTry == codeAnswer)
                    {
                        print("you win");
                    }
                    else if (codeTry != codeAnswer && codeTry != "filler")
                    {
                        trys--;
                        codeTry = "filler";
                        number.Clear();
                        inputs.text = "";
                        break;
                    }
                }
            }
        }
        else if (trys <= 0)
            print("GameOver");

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            number.RemoveAt(number.Count - 1);
            notes.Remove(notes.Length - 1);
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
        }        
    }

    public void Save()
    {
        codeTry = inputs.text;
        fire = true;

        for (int i = 0; i < number.Count; i++)
        {
            print(number[i].ToString());
        }        
    }
}
