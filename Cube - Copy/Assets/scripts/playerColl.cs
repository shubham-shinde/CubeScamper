 using UnityEngine;

public class playerColl : MonoBehaviour {

    public playerMovement movement;

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<AudioManager>().Play("PlayerDeath");
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
