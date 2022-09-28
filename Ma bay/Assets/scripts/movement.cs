using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 20;

    void Start()
    {
        
    }

    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);

        float verticalInput = Input.GetAxisRaw("Vertical");

        transform.Translate(Vector3.up * verticalInput * speed * Time.deltaTime);
    }
}
