using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;

    public float speed = 5f;

    public float jumpSpeed = 10f;

    public float distToGround;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();

            BoxCollider col = gameObject.GetComponent<BoxCollider>();
           distToGround = col.bounds.extents.y;
    }

    // Update is called once per frame
    void Update()
    {
       float horAxis;

        if(Input.GetButtonDown("Jump")){
            rb.AddForce(new Vector3(0, jumpSpeed, 0 ));

        }


       horAxis = Input.GetAxis("Horizontal") * speed;

       rb.AddForce(new Vector3 (horAxis, 0, 0 ));


    }
}
