using Unity.VisualScripting;
using System.Collections;
using UnityEngine;

public class Locomotion : MonoBehaviour
{
    // Update is called once per frame
    public Rigidbody body;
    public float force = 2000f; 
    public float sideForce = 600f;
    void FixedUpdate()
    {
        body.AddForce(0, 0, force * Time.deltaTime);
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            body.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            body.AddForce(-sideForce * Time.deltaTime, 0, 0 , ForceMode.VelocityChange  );
        }
        if(body.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();  
        }
    }
}
    
