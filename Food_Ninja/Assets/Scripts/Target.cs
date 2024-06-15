using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SocialPlatforms.Impl;

public class Target : MonoBehaviour
{
    private GameManager _gameManager;
    private Rigidbody _itemsRB;

    private float _torque = 10f;
    private float _maxSpeed = 16f;
    private float _minSpeed = 12.0f;
    private float _XRange = 4;
    private float _ySpawnPos = -4;
    [SerializeField]
    private int pointValue;

    private void Start()
    {
        _itemsRB = GetComponent<Rigidbody>();
        _gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();

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

    private void OnMouseDown()
    {
        Destroy(gameObject);
        _gameManager.UpdateScore(pointValue);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

}
