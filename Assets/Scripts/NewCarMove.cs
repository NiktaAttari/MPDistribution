using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCarMove : MonoBehaviour
{
    public GameObject VehiclePolice1;
    public GameObject Cube;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        VehiclePolice1.transform.position = Vector3.MoveTowards(VehiclePolice1.transform.position, Cube.transform.position, speed);
    }
}
