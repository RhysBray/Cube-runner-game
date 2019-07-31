using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //accesses the values in the rigidbody, needs to be dragged in from the unity editor
    public Rigidbody rb;

    // variables apear in the unity editor in this script component
    public float ForwardForce = 750f;
    public float SidewaysForce = 100f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame 
    // FixedUpdate for physics manipulation
    void FixedUpdate()
    {
        // adds a force to push the player forward
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);

        // adds a sideways force when a key is pressed/held
        if (Input.GetKey("d"))
        {
            rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
