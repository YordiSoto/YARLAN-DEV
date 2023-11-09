using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    Rigidbody rb;
    float velocidad = 15f;
    float ejex, ejez;
    bool grounded = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && grounded == true){ 
            rb.AddForce(1f, 5f, 0f, ForceMode.Impulse);
            grounded = false;
        }
            ejex = Input.GetAxis("Horizontal") * velocidad * Time.deltaTime;
        ejez = Input.GetAxis("Vertical") * velocidad * Time.deltaTime;
        transform.Translate(ejex, 0, ejez);
    }


    public void OnCollisionStay(Collision collision)
    {
    if(collision.collider.tag == "Piso")
        {
            grounded = true;
        }
    }


}