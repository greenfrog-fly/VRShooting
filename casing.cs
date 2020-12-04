using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class casing : MonoBehaviour
{
    //薬莢制御
    private AudioSource gun_audio;
    public AudioClip audio_cas;
    public float speed;

    public GameObject cas;
    Rigidbody rig;

    // Start is called before the first frame update
    void Start()
    {
        cas = this.gameObject;
        gun_audio = gameObject.AddComponent<AudioSource>();
        rig = cas.GetComponent<Rigidbody>();
        rig.velocity = transform.right * speed;
        Destroy(cas, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        gun_audio.PlayOneShot(audio_cas);
    }
}
