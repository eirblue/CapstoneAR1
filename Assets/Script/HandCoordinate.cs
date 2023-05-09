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


    GameObject skeleton;
    GameObject stage;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

        skeleton = GameObject.Find("SkeletonParent").transform.GetChild(1).transform.GetChild(8).gameObject;

        //Debug.Log(skeleton.name);
        Vector3 position = skeleton.transform.position;
        handcoord.text = "Hand :: " + position.ToString();



        stage = GameObject.Find("Stage");
        Vector3 stagepos = stage.transform.position;
        stagecoord.text = "Stage :: \n" + stagepos.ToString();
        // Debug.Log(stagecoord.text);



    }
}
