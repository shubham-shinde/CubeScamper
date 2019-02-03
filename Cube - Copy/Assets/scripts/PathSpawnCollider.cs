using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathSpawnCollider : MonoBehaviour
{
    public float positionZ = 0.81f;
    public Transform PathSpawnPoints;
    public GameObject Path;
    public int MinEasy = 10;
    public int MaxHard = 40;
    public GameObject[] combinations;

    // Update is called once per frame
    void OnTriggerEnter(Collider hit)
    {

        //player has hit the collider
        //Debug.Log("Collided");
        int siz = combinations.Length;
        int speedMul = FindObjectOfType<score>().scoreUpdateInt();
        int inde = 0;
        if (speedMul < MinEasy)
        {
            inde = Random.Range(0, siz /2);
        }
        else if(speedMul > MaxHard)
        {
            inde = Random.Range(siz / 2, siz);
        }
        else
        {
           inde = Random.Range(0, siz);
        }

        Debug.Log(inde);

        if (hit.gameObject.tag == Constants.PlayerTag)
        {
            Instantiate(Path, PathSpawnPoints.position, PathSpawnPoints.rotation);
            Instantiate(combinations[inde], PathSpawnPoints.position, PathSpawnPoints.rotation);
        }
    }
}
