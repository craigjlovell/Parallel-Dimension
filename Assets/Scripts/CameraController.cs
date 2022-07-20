using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraController : MonoBehaviour
{
    public CinemachineVirtualCamera VCam_Active;
    public CinemachineVirtualCamera VCam_Inactive1;
    public CinemachineVirtualCamera VCam_Inactive2;
    public CinemachineVirtualCamera VCam_Inactive3;
    public GameObject closeZoomCanvas;
    public CipherScript cipher;
    public GameObject Collider_SimonSays;
    public GameObject Collider_Safe;
    public GameObject Collider_Computer;
    private void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }
    private void OnMouseDown()
    {
        VCam_Active.Priority = 1;
        VCam_Inactive1.Priority = 0;
        VCam_Inactive2.Priority = 0;
        VCam_Inactive3.Priority = 0;
        closeZoomCanvas.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        //Cursor.lockState = CursorLockMode.Confined;
        if (cipher != null)
        {
            cipher.enabled = true;
        }

        Collider_Computer.SetActive(false);
        Collider_Safe.SetActive(false);
        Collider_SimonSays.SetActive(false);
    }

    public void CancelZoom()
    {
        VCam_Active.Priority = 1;
        VCam_Inactive1.Priority = 0;
        VCam_Inactive2.Priority = 0;
        VCam_Inactive3.Priority = 0;
        closeZoomCanvas.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        cipher.enabled = false;
        Collider_Computer.SetActive(true);
        Collider_Safe.SetActive(true);
        Collider_SimonSays.SetActive(true);
    }
}
