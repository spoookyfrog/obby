using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
        float horizontal;
        float vertical;
        float jumpHeight;
        public float speed = 6.5f;
        Rigidbody playerRB;

        bool = whentoJump;

    // Start is called before the first frame update
    void Start()
    {

        jumpHeight = 10;

        playerRB = GetComponent<Rigidbody>();

        whentoJump = false;

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");

        vertical = Input.GetAxis("Vertical");

        transform.Translate(horizontal * speed * Time.deltaTime, 0, vertical * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && whentoJump == true)
        {

            playerRB.AddForce(Vector3.up * jumpheight, ForceMode.Impulse);
            whentoJump = false;

        }

    public void OnCollisionEnter(Collision other)
    {
        whentoJump = true;
    }
    }
}
