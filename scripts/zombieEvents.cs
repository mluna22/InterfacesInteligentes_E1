using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieEvents : MonoBehaviour
{
    GameObject[] spiders;
    bool chairTouched;
    float speed;
    void Start()
    {
        speed = 2;
        spiders = GameObject.FindGameObjectsWithTag("arañas");
    }

    void Update()
    {
        if (chairTouched) {
            foreach (GameObject obj in spiders) {
                Vector3 direction = (transform.position - obj.transform.position).normalized;
                obj.transform.Translate(direction * speed * Time.deltaTime, Space.World);
            }
        }
    }

    // Cambiado OnCollisionEnter a OnTriggerEnter
    // Sillas como IsKinematic y Trigger, Zombie como objeto físico
    // Todo con Box Colliders 
    void OnTriggerEnter(Collider trigger) {
        if (trigger.gameObject.tag == "sillas") {
            chairTouched = true;
        }
    }
}
