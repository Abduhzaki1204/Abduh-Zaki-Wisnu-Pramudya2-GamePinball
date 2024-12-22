using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoomOutController : MonoBehaviour
{
    public Collider bola;
    public Camera_Controller cameraController;

    public void OnTriggerEnter(Collider other)
    {

        if (other == bola)
        {
            cameraController.GoBackToDefault();
        }
    }
}
