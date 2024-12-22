using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoomInController : MonoBehaviour
{
    public Collider bola;
    public Camera_Controller cameraController;
    public float length;

    public void OnTriggerEnter(Collider other)
    {

        if (other == bola)
        {
            cameraController.FollowTarget(bola.transform, length);
        }
    }
}
