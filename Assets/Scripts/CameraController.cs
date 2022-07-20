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
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void OnMouseDown()
    {
        VCam_Active.Priority = 1;
        VCam_Inactive1.Priority = 0;
        VCam_Inactive2.Priority = 0;
        VCam_Inactive3.Priority = 0;
        closeZoomCanvas.SetActive(true);
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }

    public void CancelZoom()
    {
        VCam_Active.Priority = 1;
        VCam_Inactive1.Priority = 0;
        VCam_Inactive2.Priority = 0;
        VCam_Inactive3.Priority = 0;
        closeZoomCanvas.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
}
