using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody _itemsRB;

    private float _torque = 10f;
    private float _maxSpeed = 16f;
    private float _minSpeed = 12.0f;
    private float _XRange = 4;
    private float _ySpawnPos = -6;

    private void Start()
    {
        _itemsRB = GetComponent<Rigidbody>();

        _itemsRB.AddForce(RandomForce(), ForceMode.Impulse);
        _itemsRB.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);

        transform.position = RandomSpawnpos();
    }

    Vector3 RandomForce()
    {
        return 
            Vector3.up * Random.Range(_minSpeed, _maxSpeed);
    }
    float RandomTorque()
    {
        return 
            Random.Range(-_torque, _torque);
    }
    Vector3 RandomSpawnpos()
    {
        return 
            new Vector3(Random.Range(-_XRange, _XRange), _ySpawnPos, 0);
    }
}
