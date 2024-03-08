using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{ 
    public GameManager gamemanager; 
    public bool grounded = false;
    public Cube _cube;
    private float jumpvelocity = 10f;
    private float forwardForce = 1f;
    private float sidemomentum = .5f;
    private Rigidbody cube;
    private BoxCollider box;
    
    // Start is called before the first frame update
    void Start()
    {
        cube = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
      if(grounded = true && Input.GetKeyDown(KeyCode.Space))
      {
        Jump();
      }
    
    }
    void FixedUpdate()
    {
         cube.AddForce(Vector3.forward * forwardForce, ForceMode.VelocityChange);
       
      if(Input.GetKey(KeyCode.A))
      {
        cube.AddForce(Vector3.left * sidemomentum, ForceMode.VelocityChange);
      }
      if(Input.GetKey(KeyCode.D))
      {
        cube.AddForce(Vector3.right * sidemomentum, ForceMode.VelocityChange);
      }
      if(cube.position.y < -1)
      {
        FindObjectOfType<GameManager>().GameOver();
      }
      
     }
     void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
           
        }
        if(collision.collider.tag == "Ground")
        {
            Debug.Log("grounded");
        }
    }
    void Jump()
    {
      cube.AddForce(Vector3.up * jumpvelocity, ForceMode.VelocityChange);
    }
    
}
