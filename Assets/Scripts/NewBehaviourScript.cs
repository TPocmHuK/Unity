using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubes : MonoBehaviour
{
    public GameObject[] _Cubes;
    public float speed = 10f;

    private GameObject cube;

    private Rigidbody _rigidbody;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        // _moveAndShot = GetComponent<MoveAndShot>();
    }

    // private bool isCreated = false;

    public void createCube()
    {
        // if(isCreated){
        //     return;
        // }

        // isCreated = false;
        // GameObject Spawn = GetComponent<Spawn>();
        // if(Spawn){
        //     Debug.Log("IS OBJECT");
        // }


        Debug.Log("createCube");
        int cubeIndex = Random.Range (0, 4);
        cube =_Cubes[cubeIndex];
        // Instantiate(_Cubes[cube], transform.position, Quaternion.identity);
        Instantiate(cube, new Vector3(0, 0.3f, -7f), Quaternion.identity);
    }

    // public void setSpeed(float speed){
    //     this.speed = speed;
    // }

    // public void move(){
    //     _rigidbody.AddForce(0f, 0f, 3000);
    //     setSpeed(0f);
    // }

    // void FixedUpdate(){
    //     float sideForce = Input.GetAxis("Horizontal");
    //     // _rigidbody.AddForce(sideForce, 0f, 0f);
    //     _rigidbody.transform.Translate (Vector3.right * sideForce * speed * Time.deltaTime);
    // }
}