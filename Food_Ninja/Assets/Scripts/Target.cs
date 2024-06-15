using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody _itemsRB;

    

    private void Start()
    {
        _itemsRB = GetComponent<Rigidbody>();

        _itemsRB.AddForce(Vector3.up * Random.Range(12f, 16f), ForceMode.Impulse);
        _itemsRB.AddTorque(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10), ForceMode.Impulse);

        transform.position = new Vector3(Random.Range(-4, 4), -6, 0); 
    }
}
