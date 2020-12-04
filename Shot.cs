using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    //銃弾制御
    public  GameObject Bullet;
    public float speed;

    public float timer = 5.0f;


    public GameObject HandGun;
    public Vector3 pos;


    Rigidbody rig;


    private AudioSource target_audio;
    public AudioClip audio_hit;

    // Start is called before the first frame update
    void Start()
    {

        target_audio = gameObject.AddComponent<AudioSource>();

        HandGun = GameObject.Find("Handgun_M1911A(Clone)");

        

        Bullet = this.gameObject;
        rig = Bullet.GetComponent<Rigidbody>();
        rig.velocity = transform.up * speed;

        Destroy(Bullet, timer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("sphere"))
        {
            target_audio.PlayOneShot(audio_hit);
            


        }
    }
}
