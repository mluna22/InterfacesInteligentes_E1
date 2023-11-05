using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.T)) {
            transform.position = new Vector3(0f,0.5f,-8f);
        }
    }
}
