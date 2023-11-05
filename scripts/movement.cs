using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed;
    void Start()
    {
        speed = 20f;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) {
            transform.Rotate(0, Input.GetAxis("Horizontal2") * speed * Time.deltaTime * 10, 0, Space.World);
            transform.Translate(transform.forward * Input.GetAxis("Vertical2") * speed * Time.deltaTime, Space.World);
        }
    }
}
