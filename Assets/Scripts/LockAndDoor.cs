using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LockAndDoor : MonoBehaviour
{
    //public GameObject objectToDisable;
    //public GameObject objectToDisable2;
    public GameObject objectToEnable;

    [Header("Keypad Settings")]
    public string passwordKey = "4231";
    public string passwordInput;
    public TextMeshProUGUI displayText;

    private bool keypad;
    private float buttonClicked = 0;
    private float trys;


    // Start is called before the first frame update
    public void Start()
    {
        buttonClicked = 0;
        trys = passwordKey.Length;
    }

    // Update is called once per frame
    public void Update()
    {
        if(buttonClicked == trys)
        {
            if(passwordInput == passwordKey)
            {
                passwordInput = "";
                buttonClicked = 0;
            }
            else
            {
                passwordInput = "";
                displayText.text = passwordInput.ToString();
                buttonClicked = 0;
            }
        }    
    }

    public void OnGUI()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Cursor.lockState = CursorLockMode.Locked;
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit, 100.0f))
            {
                var selection = hit.transform;
                if(selection.CompareTag("Keypad"))
                {
                    keypad = true;
                    var selectionRender = selection.GetComponent<Renderer>();
                    if (selectionRender != null)
                        keypad = true;
                }
            }
        }

        if(keypad)
        {
            //objectToDisable.SetActive(false);
            //objectToDisable2.SetActive(false);
            objectToEnable.SetActive(true);
        }
    }

    public void InputCode(string code)
    {
        switch(code)
        {
            case "Q":
                //objectToDisable.SetActive(true);
                //objectToDisable2.SetActive(true);
                objectToEnable.SetActive(false);
                buttonClicked = 0;
                keypad = false;
                passwordInput = "";
                displayText.text = passwordInput.ToString();
                break;

            case "C":
                passwordInput = "";
                buttonClicked = 0;
                displayText.text = passwordInput.ToString();
                break;

            default:
                buttonClicked++;
                passwordInput += code;
                displayText.text = passwordInput.ToString();
                break;
        }
    }
}
