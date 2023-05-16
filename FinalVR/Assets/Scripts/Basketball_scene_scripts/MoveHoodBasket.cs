using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHoodBasket : MonoBehaviour
{
	public float speed = 0.0f;
	public float leftBound = 0.0f;
	public float rightBound = 0.0f;
    public bool isGameRunning = false; 

    // Start is called before the first frame update
    void Start()
    {
    	
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameRunning == true){
            moveBackboardHoods();
        }
    }

    public void moveBackboardHoods(){
        transform.Translate(Vector3.right*Time.deltaTime*speed);

        if(transform.position.x<leftBound){
            transform.position = new Vector3(leftBound, transform.position.y, transform.position.z);
            speed *= -1;
        }else if(transform.position.x>rightBound){
            transform.position = new Vector3(rightBound, transform.position.y, transform.position.z);
            speed *= -1;
        }
    }

    public void resetPositionsHood(){
        transform.position = new Vector3(0.0f, transform.position.y, transform.position.z);
    }

    public void changeValuesDifficultity(float speed_Diffultity, float lB_Difficultity, float rB_Difficultity){
        speed = speed_Diffultity;
        leftBound = lB_Difficultity;
        rightBound =rB_Difficultity;
    }

    public void getGameConfiguration(bool gameRunning){
        isGameRunning = gameRunning;
    }
}
