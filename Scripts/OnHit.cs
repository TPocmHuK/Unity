using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHit : MonoBehaviour
{
    public GameObject Cube_4;
    public GameObject Cube_2;
    private Rigidbody _rigidbody;
    // private bool isActiveOnHit;
    public void DestroyAndCreate()
    {
        // if (!isActiveOnHit) return;
        // isActiveOnHit = false;
        // Instantiate(Cube_4, transform.position, Quaternion.identity);
        // _rigidbody.AddForce(Vector3.up * 1500);
        // _rigidbody.AddTorque(100f, 0, 0);
        Destroy(Cube_2);
    }
}
