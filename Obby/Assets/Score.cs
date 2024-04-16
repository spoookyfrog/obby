using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int hits = 0;

   void OnCollisionEnter(Collision other)

   {
    if(other.gameObject.tag == "Hit")

    {
    hits++;
    Debug.Log(hits + " times, huh? Try to avoid it next time." );
   }

   }
}
