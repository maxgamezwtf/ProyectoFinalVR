using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeRemaining;
    public bool timerIsRunning = false;
    public TextMeshPro time_text;
    public Start_game start_game_script;
    public AudioSource[] allAudioSources;
    public AudioSource audio_end;

    void Start()
    {

    }

    void StopAllAudio()
    {
        allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach(AudioSource audioS in allAudioSources)
        {
            audioS.Stop();
        }
    }


    void Update()
    {
        if(timerIsRunning)
        {
            if(timeRemaining > 0 )
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                StopAllAudio();
                Debug.Log("Finaliza");
                timeRemaining = 0;
                timerIsRunning = false;
                start_game_script.Hide_targets();
                audio_end.Play();
            }
        }
    }

    public void SetRunning()
    {
        timerIsRunning = true;
    }

    public void StopTimer()
    {
        timerIsRunning = false;
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        time_text.text = "Time: " + string.Format("{1:00}",minutes, seconds);
    }
}
