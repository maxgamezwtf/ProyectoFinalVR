using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleScript : MonoBehaviour{
    public float speed = 50f; // Velocidad de rotación

    void Update(){
        transform.Rotate(Vector3.up, speed * Time.deltaTime); // Rotar alrededor del eje Y
    }
}