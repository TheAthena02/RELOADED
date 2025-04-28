using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSetup : MonoBehaviour
{
    public Movement Movement;

    public GameObject camera;

    public void isLocalPlayer()
    {
        Movement.enabled = true;
        camera.SetActive(true);
    }

}