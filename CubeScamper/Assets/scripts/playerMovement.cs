using UnityEngine;

public class playerMovement : MonoBehaviour {
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysforce = 500f;
    private float ScreenWidth;
    // This the reference to the rigid body component called 'rb'

    private void Start()
    {
        ScreenWidth = Screen.width;
    }

    // We marked this as "Fixed"Update because we are using
    // it to mess with physics and unity likes it a lot
    void FixedUpdate ()
    {
        int speedMul = FindObjectOfType<score>().scoreUpdateInt()/10;

        float forwardForceMul = forwardForce + speedMul * 500f;
        rb.AddForce(0, 0, forwardForceMul*Time.deltaTime);
        // add a force of 2000 on the z-axis
        // Time.deltaTime is inversly propostional to frame rate

        Touch[] myTouch = Input.touches;
        for(int i=0; i< Input.touchCount; i++)
        {
            Debug.Log(myTouch[i].position);
            float pos = myTouch[i].position.x;
            if (pos > ScreenWidth/2)
            {
                rb.AddForce(sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            else
            {
                rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        }

        if( Input.GetKey("d"))
        {
            rb.AddForce(sidewaysforce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysforce * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
        if (rb.position.y< -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
