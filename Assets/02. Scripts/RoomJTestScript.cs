using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomJTestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [SerializeField]
    private float rotateSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, rotateSpeed*Time.deltaTime);
        
    }
}
