using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ball : MonoBehaviour
{
    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
         rb=GetComponent<Rigidbody>();
        // Moves an object to the set position
       
    }
    // Update is called once per frame
    void Update()
    {
        //  if(Input.GetKeyDown(KeyCode.UpArrow)){
        // //transform.position = new Vector3(10, 0, 5);
        
        // // rb.AddForce(Vector3.right * 5);
        // rb.velocity = Vector3.forward *20f;
        //  }
         if(Input.GetKeyDown(KeyCode.LeftArrow)){
             rb.velocity = Vector3.left *20f;
         }
         if(Input.GetKeyDown(KeyCode.RightArrow)){
             rb.velocity = Vector3.right *20f;
         }
         if(Input.GetKeyDown(KeyCode.DownArrow)){
             rb.velocity = Vector3.down *20f;
         }
         if(Input.GetKeyDown(KeyCode.UpArrow))
         {
             rb.AddForce(Vector3.up * 500);
         }
    }
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
       if(collisioninfo.collider.name == "end"){
           SceneManager.LoadScene(1);
       }

    }
}
