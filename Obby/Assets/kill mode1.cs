using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killmode1 : MonoBehaviour
{
    public GameObject myPlayer;
    float positionX;
    float positionY;
    float positionZ;


    // Start is called before the first frame update
    void Start()
    {
         positionX = -5.5f;
        positionY = -77.98213f;
        positionZ = -30f;
        myPlayer = GameObject.Find("Player");

	//stage 1 checkpoint
    }

    // Update is called once per frame
    void Update()
   {
        
    }
    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Player")
        {

            myPlayer.transform.position = new Vector3(positionX, positionY, positionZ);

        }


    }


}