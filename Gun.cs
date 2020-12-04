using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;


public class Gun : MonoBehaviour
{
    //ハンドガン制御
    public SteamVR_Input_Sources rightHand;
    public SteamVR_Action_Boolean Pinch;
    public SteamVR_Action_Boolean Grip;
    public SteamVR_Action_Boolean Reload;


    private AudioSource gun_audio;
    public AudioClip audio_shot;
    public AudioClip audio_out;
    


    public SteamVR_Action_Vibration vibration;


    public int Count = 10;
    public float ReloadTime = 1.5f;

    public GameObject HandGun;
    public Vector3 pos;
    public  Vector3 world;
    

    public Shot shot;

    public GameObject Bullet;
    public GameObject Bullet1;
    public GameObject fire;
    public Transform fire1;
    public GameObject muzzle;
    public Transform muzzle1;

    public GameObject tete;
    public Transform tete1;
    public GameObject cas;
    public GameObject cas1;

    public GameObject rightcnt;

    public Rigidbody rgt1;

    public int silver;

    public GameObject silder;
    public Animation anime;

    public GameObject grip;
    public Animation trriger;

    public ParticleSystem particle;
    // Start is called before the first frame update
    void Start()
    {
        HandGun = this.gameObject;
        fire = GameObject.Find("bullet");
        tete = GameObject.Find("tetete");
        muzzle = GameObject.Find("muzzle");
        fire1 = fire.GetComponent<Transform>();
        tete1 = tete.GetComponent<Transform>();
        muzzle1 = muzzle.GetComponent<Transform>();
        rightcnt = GameObject.Find("Controller (right)");
        

        gun_audio = gameObject.AddComponent<AudioSource>();

        silver = 0;

        silder = GameObject.Find("Slider");
        anime = silder.gameObject.GetComponent<Animation>();

        grip = GameObject.Find("Trigger");
        trriger = grip.gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SteamVR_Input.GetStateDown("Reload", rightHand))
        {
            
            silver = 0;
        }

        if (silver > 0)
        {
            if (SteamVR_Input.GetStateDown("Pinch", rightHand))
            {
                Instantiate(particle,muzzle1);
                trriger.Play();
                anime.Play();
                casing();
                bullet();
                gun_audio.PlayOneShot(audio_shot);
                vibration.Execute(0, 0.1f, 100, 1f, rightHand);
                silver = silver - 1;
            }
        }
        else
        {
            if (SteamVR_Input.GetStateDown("Pinch", rightHand))
            {
                trriger.Play();
                gun_audio.PlayOneShot(audio_out);
            }
            
        }


        if(SteamVR_Input.GetStateDown("Grip", rightHand))
        {
            Destroy(HandGun);
            
        }
    }

    public void bullet()
    {
        Bullet1 = Instantiate(Bullet,fire1) as GameObject;
        Bullet1.transform.parent = null;
        
        

    }

    public void casing()
    {
        cas1 = Instantiate(cas,tete1) as GameObject;
        cas1.transform.parent = null;
    }

}
