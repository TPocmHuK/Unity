using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHit : MonoBehaviour
{
    public GameObject Cube_4;
    public GameObject Cube_2;
    private Rigidbody _rigidbody;
    // private bool isActiveOnHit;


    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject == Cube_2)
        {
            Cube_2.SetActive(false);
            Instantiate(Cube_4, transform.position, Quaternion.identity);
            _rigidbody.AddForce(Vector3.up * 1500);
            _rigidbody.AddTorque(100f, 0, 0);
        }
    }



    public void DestroyAndCreate()
    {
        // if (!isActiveOnHit) return;
        // isActiveOnHit = false;


        //Destroy(Cube_2);
    }
}
