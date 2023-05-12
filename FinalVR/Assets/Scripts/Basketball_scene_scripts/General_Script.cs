using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class General_Script : MonoBehaviour
{
    public int score_total = 0;
    public TextMeshPro score_text;
    public AudioSource audio_goal;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void AddScore(int score)
    {
        score_total += score;
        score_text.text = "Score: " + score_total;
        audio_goal.Play();
        Debug.Log("Score: " + score_total);
    }
}