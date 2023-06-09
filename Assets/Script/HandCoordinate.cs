using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandCoordinate : MonoBehaviour
{
    private TrackingInfo trackinginfo;
    private FingerInfo fingerInfo;
    private SkeletonManager skeletonmanager;
    private SkeletonInfo skeletoninfo;
    public Text handcoord;
    public Text stagecoord;
    public Text distanceHandStage;

    public Vector3 handPos;
    public Vector3 stagePos;
    public Vector3 handStageDistance;

    GameObject skeleton;
    GameObject stage;

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

        skeleton = GameObject.Find("SkeletonParent").transform.GetChild(1).transform.GetChild(8).gameObject;

        //Debug.Log(skeleton.name);
        Vector3 handPos = skeleton.transform.position;
        handcoord.text = "Hand :: " + handPos.ToString();

        stage = GameObject.Find("Stage");
        Vector3 stagePos = stage.transform.position;
        stagecoord.text = "Stage :: \n" + stagePos.ToString();
        // Debug.Log(stagecoord.text);


        handStageDistance = handPos - stagePos;
        distanceHandStage.text = "y-axis Distance :: " + Mathf.Abs(handStageDistance.y).ToString();
    }
}
