using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARPlaneDetection : MonoBehaviour
{
    public ARRaycastManager arRaycastManager = null;
    public ARPlaneManager arPlaneManager = null;
    public AROcclusionManager arOcclusionManager = null;
    public ARSession arsession = null;
    public Touch touch;
    public GameObject stageprefab;
    private GameObject stage;
    ARPlane arplane;
    GameObject score;
    GameObject currtime;
    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("Scor(TMP)");
        currtime = GameObject.Find("time(TMP)");
    }

    public bool stageSpawned = false;
    public List<ARRaycastHit> Hits = new List<ARRaycastHit>();
    // Update is called once per frame
    void Update()
    {
        if (stageSpawned == false)
        {
            arRaycastManager.Raycast(Input.GetTouch(0).position, Hits, UnityEngine.XR.ARSubsystems.TrackableType.PlaneWithinPolygon);
            arplane = GameObject.FindFirstObjectByType<ARPlane>();

            stage = Instantiate(stageprefab, Hits[0].pose.position, Hits[0].pose.rotation);
            stage.name = "Stage";
            arOcclusionManager.enabled = false;
            stageSpawned = true;

            foreach (var plane in arPlaneManager.trackables)
            {
                plane.gameObject.SetActive(false);
            }
            arPlaneManager.enabled = false;
        }
        else
        {
            stage.transform.position = Hits[0].pose.position;
            stage.transform.rotation = Hits[0].pose.rotation;
        }
    }
    public void OnClickReset()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        arsession.Reset();
        Destroy(GameObject.Find("Stage"));
        arOcclusionManager.enabled = true;
        arPlaneManager.enabled = true;
        stageSpawned = false;
        score.GetComponent<W_ScoreController>().currScore = 0;
        currtime.GetComponent<W_TimeScript>().playTime = currtime.GetComponent<W_TimeScript>().playTimestatic;

    }
}
