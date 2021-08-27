using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationLoop : MonoBehaviour
{
    public Transform tf;
    private float rotationSpeed = 5f;
    public float VeloY, VeloX, VeloZ;

    private void Update() {
        Rotate();
    }

    void Rotate() {
        tf.Rotate(new Vector3(VeloX * rotationSpeed * Time.deltaTime,
            VeloY * rotationSpeed * Time.deltaTime,
            VeloZ * rotationSpeed * Time.deltaTime));
    }
}