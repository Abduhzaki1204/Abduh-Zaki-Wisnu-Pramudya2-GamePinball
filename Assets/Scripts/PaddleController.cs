using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public KeyCode input;
    public float SpringPower;

    public HingeJoint hinge;

    // Start is called before the first frame update
    public void Start()
    {
       
    }

    // Update is called once per frame
    public void Update()
    {
        // Read Input
        ReadInput();
    }

    public void ReadInput()
    {

        JointSpring jointSpring = hinge.spring;

        if (Input.GetKey(input) )
        {
            jointSpring.spring = SpringPower;        
        }
        else
        {
            jointSpring.spring = 0;
        }

        hinge.spring = jointSpring;
    }

}
