using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    // Start is called before the first frame update
   public Transform Sphere;
   public float smoothspeed = 0.125f;
   public Vector3 offset;
   void Fixedupdate()
   {
       transform.position = Sphere.position + offset;
       transform.LookAt(Sphere);
   }
}
