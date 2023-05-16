using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Add_score_collider : MonoBehaviour
{
    public General_Script general_Script;
    
    public enum score_target
    {
        scoreEasy = 2,
        scoreNormal = 1,
        scoreHard = 1,
    };

    public score_target value_target;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        string tag = other.gameObject.tag;

        if(tag == "balon")
        {
            general_Script.AddScore((int)value_target);
        }
    }
}
