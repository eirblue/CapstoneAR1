using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballYPositionController : MonoBehaviour
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
        if (other.gameObject.CompareTag("playBoard"))
        {
            Debug.Log($"{name} landed on the board");            
            ballRb.constraints = RigidbodyConstraints.FreezePositionY;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("playBoard"))
        {
            Debug.Log($"{name} exited playboard");
            ballRb.constraints = RigidbodyConstraints.None;
        }
    }
}
