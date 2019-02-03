using UnityEngine;

public class cubejumper : MonoBehaviour
{
    //public Rigidbody rb;
    public float UpperForce = 2000f;
    

    public AudioSource MusicSource;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "playerClub")
        {
            Debug.Log("collided");
            FindObjectOfType<AudioManager>().Play("Jumper");
            //rb.AddForce(0, UpperForce * Time.deltaTime, 0, ForceMode.Impulse);
        }
    }
}
