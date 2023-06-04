using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class J_JuingongSpawnController : MonoBehaviour
{
    public GameObject juingong;

    [SerializeField]
    private bool juingongSpawned = false;    

    // Start is called before the first frame update
    void Start()
    {
        if (juingongSpawned == false)
        {
            Instantiate(juingong, transform);
        }
    }
}
