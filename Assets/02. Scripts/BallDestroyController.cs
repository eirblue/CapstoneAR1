using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroyController : MonoBehaviour
{
   

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("balls"))
        {
            Debug.Log($"{gameObject.name} collided");
            Destroy(other.gameObject);
        }
    }
}
