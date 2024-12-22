using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_Controller : MonoBehaviour
{
    public enum SwitchState
    {
        Off,
        On,
        Blink
    }

    public Collider bola;
    public Material offmaterial;
    public Material onmaterial;
    public float score;

    public ScoreManager scoreManager;

    public SwitchState state;
    public Renderer renderer;

    public void Start()
    {
        renderer = GetComponent<Renderer>();

        Set(false);

        StartCoroutine(BlinkTimerStart(5));

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            Toggle();
        }
    }

    public void Set(bool active)
    {
      
        if (active == true)
        {
            state = SwitchState.On;
            renderer.material = onmaterial;
            StopAllCoroutines();
        }
        else
        {
            state = SwitchState.Off;
            renderer.material = offmaterial;
            StartCoroutine(BlinkTimerStart(5));

        }
    }

    public void Toggle()
    {
        if (state == SwitchState.On)
        {
            Set(false);
        }
        else
        {
            Set(true);
        }

        //nambahin score
        scoreManager.AddScore(score);
    }

    public IEnumerator Blink(int times)
    {
        state = SwitchState.Blink;

        for (int i = 0; i < times; i++)
        {
            renderer.material = onmaterial;
            yield return new WaitForSeconds(0.5f);
            renderer.material = offmaterial;
            yield return new WaitForSeconds(0.5f);
        }

        state = SwitchState.Off;

        StartCoroutine(BlinkTimerStart(5));
    }

    public IEnumerator BlinkTimerStart(float time)
    {
        yield return new WaitForSeconds(time);
        StartCoroutine(Blink(2));
    }

}
