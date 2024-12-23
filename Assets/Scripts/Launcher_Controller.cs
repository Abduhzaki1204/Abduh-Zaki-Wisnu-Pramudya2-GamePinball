using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher_Controller : MonoBehaviour
{
    public Collider bola;
    public KeyCode input;

    public float maxTimeHold;
    public float maxForce;

    public bool isHold = false;

    public void OnCollisionStay(Collision collision)
    {
        if (collision.collider == bola)
        {
            ReadInput(bola); 
        }
    }

    public void ReadInput(Collider collider)
    {
        if (Input.GetKey(input) && !isHold)
        {
            StartCoroutine(StartHold(collider));
        }
    }

    public IEnumerator StartHold(Collider collider)
    {
        isHold = true;

        float force = 0.0f;
        float timeHold = 0.0f;
        while (Input.GetKey(input))
        {
            force = Mathf.Lerp(0, maxForce, timeHold/maxTimeHold);
            
            yield return new WaitForEndOfFrame();
            timeHold += Time.deltaTime;
        }
        collider.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
        isHold = false;
    }

}
