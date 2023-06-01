using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBalls : MonoBehaviour
{
	public GameObject balonBasketPrefab;
	private float xSpawnPos=3.28f;
    private float ySpawnPos=1.44f;
    private float zSpawnPos=5.92f;
    private bool isGameRunning = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnBasketBalls(){
        if(isGameRunning == true){
            Vector3 spawnPos = new Vector3(xSpawnPos,ySpawnPos,zSpawnPos);
            Instantiate(balonBasketPrefab,spawnPos,balonBasketPrefab.transform.rotation);
        }
    }
    public void getStateGame(bool stateGame){
        isGameRunning = stateGame;
    }
}
