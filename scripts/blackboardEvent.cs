using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackboardEvent : MonoBehaviour
{
    public delegate void message();
    public event message OnZombieApproach;
    public float range;
    public float distance;
    GameObject zombie;
    GameObject[] chairs;
    GameObject[] flowerpots;
    bool approached = true;
    void Start()
    {
        range = 6;
        distance = 0.5f;
        zombie = GameObject.Find("Zombie");
        chairs = GameObject.FindGameObjectsWithTag("sillas");
        flowerpots = GameObject.FindGameObjectsWithTag("macetas");
        OnZombieApproach += MoveChairsToZombi;
        OnZombieApproach += MoveFlowerpots;

    }

    void Update()
    {
        if (Vector3.Distance(gameObject.transform.position, zombie.transform.position) < range) {
            if (approached) OnZombieApproach?.Invoke();
            approached = false;
        } else approached = true;
    }

    void MoveChairsToZombi() {
        foreach (GameObject obj in chairs) {
            Vector3 direction = (zombie.transform.position - obj.transform.position).normalized;
            obj.transform.Translate(direction * distance, Space.World);
        }
    }

    void MoveFlowerpots() {
        foreach (GameObject obj in flowerpots) {
            Vector3 direction = new Vector3(Random.Range(0.0f,1.0f), 0f, Random.Range(0.0f,1.0f));
            obj.transform.Translate(direction * distance);
        }
    }

}
