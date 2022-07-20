using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParralellStateController : MonoBehaviour
{
    //other state items
    //simon says
    public SimonSays2 simonSays;

    //computer
    public GameObject computerScreen;



    //normal state items
    //simon says
    public GameObject buttonNumber0;
    public GameObject buttonNumber1;
    public GameObject buttonNumber2;
    public GameObject buttonNumber3;

    //safe
    public GameObject SafeNumbers;

    //note
    public GameObject Message;

    public GameObject trippy;
    public GameObject normal;

    //door

    //state
    public bool isOtherStateActive;
    private bool isStart = true;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Tab) || isStart)
        {
            if (!isOtherStateActive)
            {
                isOtherStateActive = true;
                simonSays.enabled = true;
                computerScreen.SetActive(true);

                buttonNumber0.SetActive(false);
                buttonNumber1.SetActive(false);
                buttonNumber2.SetActive(false);
                buttonNumber3.SetActive(false);
                SafeNumbers.SetActive(false);
                Message.SetActive(false);
                normal.SetActive(false);
            }
            else
            {
                isOtherStateActive = false;
                simonSays.enabled = false;
                computerScreen.SetActive(false);

                buttonNumber0.SetActive(true);
                buttonNumber1.SetActive(true);
                buttonNumber2.SetActive(true);
                buttonNumber3.SetActive(true);
                SafeNumbers.SetActive(true);
                Message.SetActive(true);
                normal.SetActive(true);
            }
            isStart = false;
        }
    }
}
