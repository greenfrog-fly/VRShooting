using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Mag : MonoBehaviour
{
    //マガジン制御
    public SteamVR_Input_Sources leftHand;
    public SteamVR_Action_Boolean Pinch;
    public SteamVR_Action_Boolean Grip;


    public GameObject Magazine;

    

    public GameObject MagShell;
    public Gun gun;

    public GameObject RHand;
    RightHand rightHand;

    // Start is called before the first frame update
    void Start()
    {
        Magazine = this.gameObject;

        MagShell = GameObject.Find("Handgun_M1911A(Clone)");
        gun = MagShell.GetComponent<Gun>();

        RHand = GameObject.Find("Model");
        rightHand = RHand.GetComponent<RightHand>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SteamVR_Input.GetStateDown("Grip", leftHand))
        {
            Destroy(Magazine);

        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("under"))
        {
            if (rightHand.tes == true)
            {
                
                gun.silver = 10;
                Destroy(Magazine);
            }

        }
    }
}
