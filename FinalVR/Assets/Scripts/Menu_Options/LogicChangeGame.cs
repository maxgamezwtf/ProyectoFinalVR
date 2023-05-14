using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicChangeGame : MonoBehaviour
{
	public GameObject gameMenu;
    private SetGameType optionGame;
    private int gameSelected = 0;

    // Start is called before the first frame update
    void Start(){
        //optionGame = GameObject.Find("GameMenu").GetComponent<SetGameType>();
        optionGame = gameMenu.GetComponent<SetGameType>();

    }

    // Update is called once per frame
    void Update(){
        gameSelected = optionGame.gameSceneIndex;
    }

    public void ChangeGame(){
    	SceneManager.LoadScene(gameSelected);
    }
}
