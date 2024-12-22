using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIScore : MonoBehaviour
{


    public TMP_Text scoreText;

    public ScoreManager scoreManager;

    public void Update()
    {
        scoreText.text = scoreManager.score.ToString();
    }
}
