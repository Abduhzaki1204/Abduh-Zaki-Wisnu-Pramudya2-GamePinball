using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScoreRamp : MonoBehaviour
{
    public float score;


    public Collider bola;
    public ScoreManager scoreManager;

    public void OnTriggerEnter(Collider other)
    {

        if (other == bola)
        {
            //nambahin score
            scoreManager.AddScore(score);
        }
    }
}
