using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float forceMultiplier = 5;

    private Rigidbody rb;



    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        // rb.mass = 10f;
    }

    //Update is called once per frame

    // private void FixedUpdate()
    //{
    //    float horizontal = Input.GetAxis("Horizontal");
    //    float vertical = Input.GetAxis("Vertical");
    //    Vector3 movement = new Vector3(horizontal, 0, vertical);
    //    rb.AddForce(movement * forceMultiplier);
    //}

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0, vertical);

        // Llama esto en el GameObject
        transform.Translate(movement * forceMultiplier * Time.deltaTime);
    }
}
