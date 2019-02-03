using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDistroyerCom : MonoBehaviour
{
    public float LifeTime = 10f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyObjectComb", LifeTime);
    }

    // Update is called once per frame
    void DestroyObjectComb()
    {
        Destroy(gameObject);
    }
}
