using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropSPin : MonoBehaviour
{
    public float rotationSpeed = 100.0f;
    public Vector3 rotationDirection = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationDirection * rotationSpeed * Time.deltaTime);
    }
}
