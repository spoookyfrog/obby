using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yougothit : MonoBehaviour

{
    private Color lightBlue;
    private Color red;

    // Start is called before the first frame update
    void Start()
    {
        lightBlue = new Color(0.57f, 0.73f, 1f, 1f);
        red = new Color(1f, 0f, 0f, .5f);

        GetComponent<MeshRenderer>().material.color = lightBlue;
    }

    // Update is called once per frame
    void Update()
    {
    
        
    }
    void OnCollisionEnter(Collision other)

    {
        if (other.gameObject.tag != "Hit")

        {
            return;
        }

        GetComponent<MeshRenderer>().material.color = red;

        Debug.Log("Collision Detected!");
    }

    void OnCollisionExit (Collision other)
   {
      if(other.gameObject.tag == "Hit" )

    　{
    
    　　GetComponent<MeshRenderer>().material.color = lightBlue;
    
       Debug.Log( "exit Collision Detected!");
    　}
   }
}
