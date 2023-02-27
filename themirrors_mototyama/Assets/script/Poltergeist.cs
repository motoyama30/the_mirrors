using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Poltergeist : MonoBehaviourPun
{
    public bool startaudio = false;
    public bool listenaudio = false;
    public bool playing = false;
    public GameObject partnerclock;
    GameObject camera;
    AudioListener AudioListener;
    Poltergeist partnerpoltergeist;
    public AudioClip audioclip;
    

    private void Awake()
    {
        camera = GameObject.Find("Camera");
        partnerpoltergeist = partnerclock.GetComponent<Poltergeist>();
        AudioListener = camera.GetComponent<AudioListener>();
        
    }

    private void Update()
    {
        if (listenaudio && partnerpoltergeist.startaudio)
        {
            if (!playing)
            {
                StartCoroutine("audiocoroutine");
                playing = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Killer"))
        {
            Debug.Log("hitkiller");
            startaudio = true;
        }
        else if(collision.gameObject.CompareTag("Player"))
        {
            if (collision.GetComponent<PhotonView>().IsMine)
            {
                listenaudio = true;
                //AudioListener.enabled = true;
            }
            Debug.Log("hitplayer");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Killer"))
        {
            startaudio = false;
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.GetComponent<PhotonView>().IsMine)
            {
                listenaudio = false;
                //AudioListener.enabled = false;
            }
            
        }
    }

    IEnumerator audiocoroutine()
    {
        GetComponent<AudioSource>().PlayOneShot(audioclip);
        yield return new WaitForSeconds(4.0f);
        GetComponent<AudioSource>().Stop();
    }

}
