using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimonSays : MonoBehaviour
{
    public List<GameObject> gameButtonPrefab;
    public List<GameObject> gameButtons;

    public Transform gameFieldPanelTransform;

    public List<ButtonSettings> buttonSettings;

    public float[] seq1 = new float[1] { 2 };
    public float[] seq2 = new float[2] { 2, 0 };
    public float[] seq3 = new float[3] { 2, 0, 1 };
    public float[] seq4 = new float[4] { 2, 0, 1, 3 };

    public float[] safeCode = { 2, 0, 1, 3 };

    bool inputEnabled = false;
    bool gameOver = false;

    System.Random rg;

    int bleepCount = 3;

    List<int> bleeps;
    List<int> playerBleeps;

    // Start is called before the first frame update
    void Start()
    {
        gameButtons = new List<GameObject>();

        ButtonCreating(0, new Vector3(-0.1045986f, 0.25f, 1.511185f));
        ButtonCreating(1, new Vector3(0.3954014f, 0.25f, 1.511185f));
        ButtonCreating(2, new Vector3(-0.1045986f, -0.25f, 1.511185f));
        ButtonCreating(3, new Vector3(0.3954014f, -0.25f, 1.511185f));

        StartCoroutine(SimonSaysEnum());
    }

    IEnumerator SimonSaysEnum()
    {
        inputEnabled = false;

        rg = new System.Random("Test".GetHashCode());

        SetBleeps();


        yield return null;
    }

    void SetBleeps()
    {
        bleeps = new List<int>();
        playerBleeps = new List<int>();

        for (int i = 0; i < bleepCount; i++)
        {
            bleeps.Add(rg.Next(0, gameButtons.Count));
        }

        bleepCount++;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ButtonCreating(int index, Vector3 position)
    {
        foreach (GameObject game in gameButtonPrefab)
        {
            game.GetComponent<Button>().onClick.AddListener(() =>
            {
                SaysButtonPressed(index);
            });

            gameButtons.Add(game);
        }


    }

    public void SaysButtonPressed(int index)
    {
        if (!inputEnabled)
            return;

        // play button glow if pressed todo
    }

    public void GameOver()
    {
        gameOver = true;
        inputEnabled = false;
    }
}
