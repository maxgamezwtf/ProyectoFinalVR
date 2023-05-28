using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class General_Script : MonoBehaviour
{
    public int score_total = 0;
    public TextMeshPro score_text;
    public AudioSource audio_goal;
    public GameObject objectCanasta;
    public GameObject particle1;
    public GameObject particle2;
    public GameObject particle3;


    void Start()
    {
        objectCanasta = GameObject.Find("Torus");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void AddScore(int score)
    {
        score_total += score;
        score_text.text = "" + score_total;
        if(score_total < 10){
        	score_text.text = "0" + score_total;
        }
        audio_goal.Play();
        StartAnimations();
        Debug.Log("Score: " + score_total);
    }
    public void restartScore(){
        score_total = 0;
        score_text.text = "00";
    }

    public void StartAnimations(){
    	Instantiate(particle1, objectCanasta.transform.position, Quaternion.identity);
    	Instantiate(particle2, objectCanasta.transform.position, Quaternion.identity);
    	Instantiate(particle3, objectCanasta.transform.position, Quaternion.identity);
    }
}