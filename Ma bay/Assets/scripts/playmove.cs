using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playmove : MonoBehaviour
{
   public float moveSpeed = 5;

   public float xRange = 8;

   private float _horizontalInput;

   public GameObject shootPrefab;
    
    void Start()
    {
        
    }


    void Update()
    {
        PlayerMovement();

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(shootPrefab, transform.position, shootPrefab.transform.rotation);
        }
    }

    void PlayerMovement()
    {
        _horizontalInput = Input.GetAxisRaw("Horizontal");

        transform.Translate(Vector3.right * _horizontalInput * moveSpeed * Time.deltaTime);

        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
    }
}
