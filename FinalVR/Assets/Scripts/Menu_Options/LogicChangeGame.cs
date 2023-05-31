using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicChangeGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
    void Update(){
        //
    }

    public void ChangeGame(int scene){
    	int startGame = scene;
    	SceneManager.LoadScene(startGame);
    }
}
