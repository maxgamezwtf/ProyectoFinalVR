using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateReticule : MonoBehaviour
{
    // Velocidad de rotación en grados por segundo
    public float rotationSpeed = 100f;

    void Update()
    {
        // Obtener la rotación actual del objeto en el eje Y
        Vector3 currentRotation = transform.eulerAngles;

        // Calcular la nueva rotación en el eje Y
        float newYRotation = currentRotation.y + rotationSpeed * Time.deltaTime;

        // Asignar la nueva rotación al objeto
        transform.eulerAngles = new Vector3(currentRotation.x, newYRotation, currentRotation.z);
    }
}
