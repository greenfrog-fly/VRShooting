using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class RightHand : MonoBehaviour
{
    //コントローラー右制御
    public SteamVR_Input_Sources rightHand;
    public SteamVR_Action_Boolean Pinch;
    public SteamVR_Action_Boolean Grip;
    public SteamVR_Action_Boolean Reload;

    public GameObject cnt;
    public Transform cnt1;
    public GameObject Pis;
    public GameObject Pis1;
    public GameObject Mag;
    public GameObject Mag1;
    public GameObject Mag2;
    

    public GameObject cntobj;
    public bool res = true;
    public bool tes = true;


    private AudioSource gun_audio;
    public AudioClip audio_remove;
    public AudioClip audio_set;

    

    // Start is called before the first frame update
    void Start()
    {
        cnt = GameObject.Find("Controller (right)");
        Debug.Log(cnt);
        
        cnt1 = cntobj.GetComponent<Transform>();

        gun_audio = gameObject.AddComponent<AudioSource>();

        

    }

    // Update is called once per frame
    void Update()
    {
        

        if (SteamVR_Input.GetStateDown("Pinch",rightHand))
        {
            print("Pinch" + "Trigger Down");
            

        }

        if (Pis1 == null)
        {
            res = true;
        }

        if (SteamVR_Input.GetStateDown("Grip", rightHand))
        {
            tes = true;
            Destroy(Mag1);

        }

        if (Mag1 == true)
        {

            if (SteamVR_Input.GetStateDown("Reload", rightHand))
            {
                gun_audio.PlayOneShot(audio_remove);
                Destroy(Mag1);
                Mag2 = Instantiate(Mag, cnt1) as GameObject;
                Mag2.AddComponent<Rigidbody>();
                Mag2.transform.parent = null;
                Destroy(Mag2, 1.5f);
                tes = true;
                

         
            }
            
        }
        

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Gun"))
        {

            if (res == true)
            {
                Pis1 = Instantiate(Pis,cnt1) as GameObject;
                Pis1.transform.parent = cntobj.transform;
                Debug.Log("benben2");
            }
            res = false;

        }

        if (collision.gameObject.CompareTag("fit"))
        {

            if (tes == true)
            {
                gun_audio.PlayOneShot(audio_set);
                Mag1 = Instantiate(Mag, cnt1) as GameObject;

                Debug.Log("gengen2");
            }
            tes = false;
        }
    }
    
}
