using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public bool keyboard = false;

    public PlayerLook look;


    void Update()
    {
        look.useMouse = true;
    }
}
