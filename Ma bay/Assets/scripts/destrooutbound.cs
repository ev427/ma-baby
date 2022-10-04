using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destrooutbound : MonoBehaviour
{

    public float topBound;

    public float lowerBound;

    void Update()
    {
        if(transform.position.y > topBound)
        {
            Destroy(this.gameObject);
        }
    }
}
