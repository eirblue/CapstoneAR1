using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class J_ballYPositionController : MonoBehaviour
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
    [SerializeField]
    bool posSet = false;

    private Vector3 initPos;

    void Start()
    {
        xPosNum = transform.position.x;
        yPosNum = transform.position.y;
        zPosNum = transform.position.z;
        ballRb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("playBoard") && posSet == false)
        {
            Debug.Log($"{name} landed on the board");
            yPosNum = other.transform.position.y + (other.transform.localScale.y + transform.localScale.y) / 2;
            transform.position = new Vector3(transform.position.x, yPosNum, transform.position.z);
            ballRb.constraints = RigidbodyConstraints.FreezePositionY;
            posSet = true;
        }
        if (tag == "ballsBarrier")
        {
            initPos = transform.position;
        }
    }

    private void Update()
    {
        if (posSet == true && tag == "ballsBarrier")
        {
            transform.position = initPos;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("playBoard") && (tag == "ballsJuingong" || tag == "balls"))
        {
            Debug.Log($"{name} exited playboard");
            ballRb.constraints = RigidbodyConstraints.None;
        }
    }
}
