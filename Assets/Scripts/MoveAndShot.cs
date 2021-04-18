using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndShot : MonoBehaviour
{
    private Rigidbody _rigidbody;
    // private MoveAndShot _moveAndShot;
    public float speed = 20f;
    // public GameObject[] Cubes;
    private bool isActiveUpdate = true;
    private bool isActiveCollision = true;
    private CreateCube _createCube;
    public GameObject spawn;
    // private bool isActiveOnHit = true;
    // public GameObject cube_2;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _createCube = spawn.GetComponent<CreateCube>();
        // _moveAndShot = GetComponent<MoveAndShot>();
    }

    void OnCollisionEnter(Collision collision)

    {
        if(collision.collider.tag == "Border")
        {
            if (!isActiveCollision) return;
            isActiveCollision = false;
            _createCube.createCube();
            // int cube = Random.Range (0, 4);
            // Instantiate(Cubes[cube], new Vector3(0, 0.3f, -7f), Quaternion.identity);
        }
        else if(collision.collider.tag == "Cube")
        {
            if (!isActiveCollision) return;
            isActiveCollision = false;
            _createCube.createCube();
            // int cube = Random.Range (0, 4);
            // Instantiate(Cubes[cube], new Vector3(0, 0.3f, -7f), Quaternion.identity);
        }
        if(collision.gameObject.GetComponent<OnHit>())
        {
            // if (!isActiveOnHit) return;
            // isActiveOnHit = false;
            collision.gameObject.GetComponent<OnHit>().DestroyAndCreate();
        }
    }

    void FixedUpdate()
    {
        // float sideForce = Input.GetAxis("Horizontal") * speed;
        float sideForce = Input.GetAxis("Horizontal");
        // _rigidbody.AddForce(sideForce, 0f, 0f);
        _rigidbody.transform.Translate (Vector3.right * sideForce * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (!isActiveUpdate) return;
            isActiveUpdate = false;
            _rigidbody.AddForce(0f, 0f, 3000);
            speed = 0;
            // this._moveAndShot.enabled = false;
        }
        
    }
}