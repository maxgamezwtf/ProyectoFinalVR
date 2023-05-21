using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetDifficulty : MonoBehaviour
{
	//easy[speed:0] - normal[speed:3] - Hard[speed:11] 
	private int[ ] speed_difficultyType = {0,6,14}; 
	//easy[ 0>0 ] - normal[  -2.2 > 1.8 ] - Hard[ -4.4 > 4.2 ]
	private float[ ] leftPositions = {0.0f,-2.2f,-4.4f};  
	private float[ ] rightLimits = {0.0f,1.8f,4.2f}; 
	public int[] timeDifficulty = {60,25,15};
	public MoveHoodBasket firstHoodBasketScript;
	public Timer timerScript;

    public void SetDifficultyType(int index){
    	switch (index){
	        case 2:
	            //Debug.Log("Hardcore");
	            firstHoodBasketScript.changeValuesDifficultity(speed_difficultyType[index],leftPositions[index],rightLimits[index]);
	            timerScript.restartTime(timeDifficulty[index]);
	            break;
	        case 1:
	            //Debug.Log("Normal");
	            firstHoodBasketScript.changeValuesDifficultity(speed_difficultyType[index],leftPositions[index],rightLimits[index]);
	            timerScript.restartTime(timeDifficulty[index]);
	            break;
	        case 0:
	            //Debug.Log("Easy");
	            firstHoodBasketScript.changeValuesDifficultity(speed_difficultyType[index],leftPositions[index],rightLimits[index]);
	            timerScript.restartTime(timeDifficulty[index]);
	            break;
	        default:
	            Debug.Log("No especific");
	            break;
        }
    }

}
