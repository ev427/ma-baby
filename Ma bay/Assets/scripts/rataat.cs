using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rataat : MonoBehaviour
{

    public float speed = 10;
    public float rotationSpeed = 100;
    
    void Start()
    {
        
    }

    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");
        
        transform.Translate(Vector3.up * verticalInput * speed * Time.deltaTime);

        transform.Rotate(Vector3.back, horizontalInput * rotationSpeed * Time.deltaTime);
    }
}
