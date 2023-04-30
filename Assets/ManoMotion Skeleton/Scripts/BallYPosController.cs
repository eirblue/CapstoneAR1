using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallYPosController : MonoBehaviour
{
    [SerializeField]
    float xPosNum;
    [SerializeField]
    float yPosNum;
    [SerializeField]
    float zPosNum;
    [SerializeField]
    Vector3 resetPos;

    Rigidbody ballRb;

    void Start()
    {
        xPosNum = transform.position.x;
        yPosNum = transform.position.y;
        zPosNum = transform.position.z;
        ballRb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("returner"))
        {
            Debug.Log($"{gameObject.name} collided");
            ballRb.useGravity = false;
            resetPos = new Vector3(xPosNum, yPosNum, zPosNum);
            transform.position = resetPos;            
        }
        if (other.gameObject.CompareTag("GamePlane"))
        {
            ballRb.useGravity = true;
        }
    }
}
