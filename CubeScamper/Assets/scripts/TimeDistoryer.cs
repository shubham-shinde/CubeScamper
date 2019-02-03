using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDistoryer : MonoBehaviour
{
    public float LifeTime = 10f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyObject", LifeTime);
    }

    // Update is called once per frame
    void DestroyObject()
    {
        Destroy(gameObject);
    }
}
