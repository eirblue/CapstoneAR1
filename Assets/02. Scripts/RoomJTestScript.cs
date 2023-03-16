using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomJTestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float rotationSpeed;
    public Vector3 rotationOrigin;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);        
    }
}
