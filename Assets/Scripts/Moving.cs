using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float speed = 50f;
    
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {_rigidbody.AddForce(0f, 300, 0f);}
    }


    void FixedUpdate()
    {
        float sideForce = Input.GetAxis("Horizontal") * speed;
        _rigidbody.AddForce(sideForce, 0f, 0f);
    }

}
