using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    Canvas canvas = null;

    public float mouseSpeed = 350;

    public Transform playerBody;

    public float xRot = 0f;
    public float yRot = 0f;

    public bool useMouse = false;
    public bool useKeyboard = false;

    float mouseX = 0f;
    float mouseY = 0f;

    void Start()
    {
        canvas = GameObject.FindGameObjectWithTag("Game").GetComponent<Canvas>();
    }
    void Update()
    {


        if (useMouse == true)
        {
            mouseX = Input.GetAxis("Mouse X") * mouseSpeed * Time.deltaTime;
            mouseY = Input.GetAxis("Mouse Y") * mouseSpeed * Time.deltaTime;
            if (canvas.enabled == true)
            {
                Cursor.lockState = CursorLockMode.Locked;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Confined;
            }
        }
        else if (useKeyboard == true)
        {
            mouseX = Input.GetAxis("HozX") * mouseSpeed * Time.deltaTime;
            mouseY = Input.GetAxis("VertY") * mouseSpeed * Time.deltaTime;
            if (canvas.enabled == true)
            {
                Cursor.lockState = CursorLockMode.Locked;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Confined;
            }
        }

        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, -90f, 90f);

        yRot += mouseX;

        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
        playerBody.transform.localRotation = Quaternion.Euler(0f, yRot, 0f);
    }
}