using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bridge : MonoBehaviour
{
    Rigidbody rb;
    Vector3 vec;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        vec.y = 50;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("sencor"))
        {
            //Vector3 vec;
            vec.x = rb.velocity.x * 10;
            vec.y += 50;
            vec.z = 0;
            rb.velocity = Vector3.zero;
            rb.AddForce(vec.normalized * 800);
        }

    }
}
