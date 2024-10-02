using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movehero : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        if (animator == null)
            print("Could not find Animator Component");
        else
            print("Animator Component found");
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("isrunning", false);
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime;
            animator.SetBool("isrunning", true);
        }

        if (Input.GetKey(KeyCode.A))
            transform.Rotate(Vector3.up, 30 * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.down, 30 * Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
            transform.position += Vector3.back * Time.deltaTime;
    
    }
}
