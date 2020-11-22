/*using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    //void Start()
    //{
        
    //}
    public float forwardForce = 500f;
    public float sideForce = 10f;
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce * Time.deltaTime);
        if(Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime , 0 ,0, ForceMode.VelocityChange);
        }
        
        if(Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime , 0 ,0,ForceMode.VelocityChange);
        }
    }
}
*/
using UnityEngine;

public class playermovement : MonoBehaviour {

	// This is a reference to the Rigidbody component called "rb"
	public Rigidbody rb;

	public float forwardForce = 2000f;	// Variable that determines the forward force
	public float sidewaysForce = 500f;  // Variable that determines the sideways force

	// We marked this as "Fixed"Update because we
	// are using it to mess with physics.
	void FixedUpdate ()
	{
		// Add a forward force
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);

		if (Input.GetKey("d"))	// If the player is pressing the "d" key
		{
			// Add a force to the right
			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (Input.GetKey("a"))  // If the player is pressing the "a" key
		{
			// Add a force to the left
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		if (rb.position.y < -1f)
		{
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
