using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void OnCollisionEnter(Collision collisioninfo)
    {
        int s;
       // Debug.Log("collison");
        if(collisioninfo.collider.name == "Sphere"){
           Debug.Log("we hit a Sphere");
           s=0;
           int a = s+1;
           Debug.Log(a);
           Destroy(gameObject);
        }
        if (collisioninfo.gameObject.tag == "Enemy")
         {
              Destroy(GameObject.FindWithTag("Enemy"));
         }
       // Movement.enable = false;
       if(collisioninfo.gameObject.name == "cube")
       {
           Destroy(gameObject);
       }

    }


}
