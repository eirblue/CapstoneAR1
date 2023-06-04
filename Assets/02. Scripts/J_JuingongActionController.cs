using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class J_JuingongActionController : MonoBehaviour
{
    Vector3 colDir = new Vector3();
    Rigidbody juingongRb;
    [SerializeField]
    float forceParam;
    void Start()
    {
        juingongRb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("balls"))
        {
            colDir = (transform.position - collision.transform.position).normalized;
            juingongRb.AddForce(colDir * forceParam, ForceMode.VelocityChange);
            //collision.rigidbody.AddForceAtPosition(-colDir, transform.position + colDir * (transform.localScale.x)*2, ForceMode.Force);
        }
    }
}
