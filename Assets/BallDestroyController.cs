using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroyController : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("balls"))
        {
            Debug.Log($"{collision.gameObject.name} has escaped. Now deleting.111111111111111111111111111111111111111111111111");
Debug.Log($"Woohyun sososososososososososo cute");
            Destroy(collision.gameObject);
        }
    }
}
