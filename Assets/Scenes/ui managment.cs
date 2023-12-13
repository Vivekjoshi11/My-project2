using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uimanagment : MonoBehaviour
{
    // Start is called before the first frame update
   void openscene(){
       SceneManager.LoadScene(0);
   }
}
