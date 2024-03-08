
using UnityEngine;

public class CubeCollision : MonoBehaviour
{
    public bool grounded = false;
    public Cube cube;
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
           
        }
        if(collision.collider.tag == "Ground")
        {
            grounded = true;
            Debug.Log("grounded");
        }
    }
   
}
