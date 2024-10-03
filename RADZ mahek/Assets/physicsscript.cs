using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physicsscript : MonoBehaviour
{
    private Rigidbody rb;

    internal void kick()
    {
        print("Found Rigid Body");

    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb != null)
            print("Found Rigid Body");
        else
            print("Could not find Rigid Body");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            rb.AddExplosionForce(500,
                transform.position + new Vector3(0, -1, -1), 2);
    }


}
