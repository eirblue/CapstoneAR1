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
    public Vector3 position;
    public Vector3 stagepos;

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
        position = skeleton.transform.position;
        handcoord.text = "Hand :: " + position.ToString();



        stage = GameObject.Find("Stage");
        stagepos = stage.transform.position;
        stagecoord.text = "Stage :: \n" + stagepos.ToString();
        // Debug.Log(stagecoord.text);



    }
}
