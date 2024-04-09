using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovementTest : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Car;
    public GameObject Cube;
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Car.transform.position = Vector3.MoveTowards(Car.transform.position, Cube.transform.position, speed);
    }
}
