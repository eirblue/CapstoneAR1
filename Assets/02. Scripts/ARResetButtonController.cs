using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

public class Resetbtn : MonoBehaviour
{

    public ARSession arsession = null;
    public ARPlaneManager arPlaneManager = null;
    public AROcclusionManager arOcclusionManager = null;
    GameObject detectionManager;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnClickReset()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        arsession.Reset();
        detectionManager = GameObject.Find("PlanedetectionManager");
        Destroy(GameObject.Find("Stage"));
        arOcclusionManager.enabled = true;
        arPlaneManager.enabled = true;
        detectionManager.GetComponent<ARPlaneDetection>().stageSpawned = false;


    }
}