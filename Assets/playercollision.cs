
using UnityEngine;

public class playercollision : MonoBehaviour

{
    public playermovement movement;
    // Start is called before the first frame update
    void OnCollisionEnter (Collision coll)
    {
        
        if(coll.collider.tag == "obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
