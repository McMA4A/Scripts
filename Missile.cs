using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public int speed = 2;
    void Start()
    {
        Destroy(gameObject, 3);
        print("create");
    }
    void Update()
    {
        transform.position +=
transform.forward *
speed * Time.deltaTime;

    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
