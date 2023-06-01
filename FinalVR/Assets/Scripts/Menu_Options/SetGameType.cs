using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SetGameType : MonoBehaviour
{
    public int gameSceneIndex = 0;

    public void SetGameTypeIndex(int index){
    	gameSceneIndex = index;
    }
}
