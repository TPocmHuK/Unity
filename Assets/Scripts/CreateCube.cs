using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCube : MonoBehaviour
{
    public GameObject[] Cubes;

    void Start() 
    {
        int cube = Random.Range (0, 4);
        Instantiate(Cubes[cube], transform.position, Quaternion.identity);
    }
    
}
