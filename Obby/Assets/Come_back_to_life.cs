using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comebacktolife : MonoBehaviour
{
    float positionX;
    float positionY;
    float positionZ;

    // Start is called before the first frame update
    void Start()
    {
      positionX = -5.5f;
      positionY = -77.98213f;
      positionZ = -30f;
    //this is the position where the player is going to revive//

      transform.position = new Vector3(positionX, positionY, positionZ); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
