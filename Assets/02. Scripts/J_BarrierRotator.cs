using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class J_BarrierRotator : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed;
    [SerializeField]
    private int rotationParameter;

    private void Start()
    {
        rotationSpeed = Random.Range(150, 400);
        rotationParameter = Random.Range(1, 10);
        if (rotationParameter % 2 == 0)
        {
            rotationSpeed *= -1;
        }
    }
    void Update()
    {
        transform.Rotate(Vector3.up * Mathf.Sin(Time.deltaTime) * rotationSpeed);
    }
}
