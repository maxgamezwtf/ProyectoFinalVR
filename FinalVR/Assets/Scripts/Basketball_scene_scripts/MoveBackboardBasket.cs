using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackboardBasket : MonoBehaviour
{
	public float speed= 0.0f;
	public float leftBound = 0.0f;
	public float rightBound = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*Time.deltaTime*speed);
        if(transform.position.z>leftBound){
        	speed = speed * - 1;
        }else if(transform.position.z<rightBound){
        	speed = speed * - 1;
        }
    }
}
