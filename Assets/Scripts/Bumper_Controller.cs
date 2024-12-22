using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper_Controller : MonoBehaviour
{
    public Collider bola;
    public float multiplier;
    public float score;


    public Audio_Manager audioManager;
    public VFX_Manager vfxManager;
    public ScoreManager scoreManager;
   
    public Animator animator;


    public void Start()
    {
    
        animator = GetComponent<Animator>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multiplier;

            animator.SetTrigger("hit");

            //mainin sfx
            audioManager.PlaySFX(collision.transform.position);

            //nyalain vfx
            vfxManager.PlayVFX(collision.transform.position);

            //nambahin score
            scoreManager.AddScore(score);

        }
    }
}
