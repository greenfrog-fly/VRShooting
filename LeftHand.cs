using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class LeftHand : MonoBehaviour
{
    //コントローラー左制御
    public SteamVR_Input_Sources leftHand;
    public SteamVR_Action_Boolean Pinch;
    public SteamVR_Action_Boolean Grip;


    public GameObject cntl;
    public Transform cntl1;
    public GameObject cntlobj;


    public GameObject Mag;
    public GameObject Mag1;
    public bool res1 = true;

    public GameObject MagShell;
    RightHand rightHand;

    // Start is called before the first frame update
    void Start()
    {
        cntl1 = cntlobj.GetComponent<Transform>();
        MagShell = GameObject.Find("Model");
        rightHand = MagShell.GetComponent<RightHand>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Mag1 == null)
        {
            res1 = true;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (rightHand.res == false)
        {
            if (collision.gameObject.CompareTag("Mag"))
            {

                if (res1 == true)
                {
                    Mag1 = Instantiate(Mag, cntl1) as GameObject;
                    Mag1.transform.parent = cntlobj.transform; 
                    Debug.Log("dondon2");
                }
                res1 = false;

            }
        }
    }
}
