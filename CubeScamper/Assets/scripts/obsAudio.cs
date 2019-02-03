using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obsAudio : MonoBehaviour
{

    // Update is called once per frame

    public AudioSource MusicSource;

    void OnCollisionEnter(Collision hitInfo)
    {
        if (hitInfo.collider.tag == Constants.PlayerTag)
        {
            Debug.Log("called");
            MusicSource.Play();
        }
    }
}
