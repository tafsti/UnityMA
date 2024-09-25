using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physicsscript : MonoBehaviour
{
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
            print("Found Rigid Body");
        else
            print("could not find rigid body");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            rb.AddExplosionForce(500,
                transform.position + new Vector3(0, -1, 0), 2);
    }
}
