using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBalls : MonoBehaviour
{
	public GameObject balonBasketPrefab;
	private float xSpawnPos=0.6f;
	private float ySpawnPos=1.1f;
	private float zSpawnPos=0.8f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnBasketBalls(){
    	Vector3 spawnPos = new Vector3(xSpawnPos,ySpawnPos,zSpawnPos);
    	Instantiate(balonBasketPrefab,spawnPos,balonBasketPrefab.transform.rotation);
    }
}
