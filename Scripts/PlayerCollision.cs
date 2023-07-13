using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Locomotion motion;   
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log(collisionInfo.collider.name);
            motion.enabled = false;
            FindObjectOfType<GameManager>().EndGame(); 
        }
    }
}
