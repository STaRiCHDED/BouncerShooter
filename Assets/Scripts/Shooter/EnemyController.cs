using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _rotationSpeed;

    private const float ENEMY_CENTER = 2f;
    
    private EnemySpawner _enemySpawner;
    private Camera _actor;
    private Vector3 _actorPosition;
    
    void Start()
    {
        _actor = FindObjectOfType<Camera>();
        _enemySpawner = FindObjectOfType<EnemySpawner>();
        Debug.Log(_enemySpawner.name);
    }
    
    void Update()
    {
        _actorPosition = _actor.transform.position;
        //Debug.Log($"Actor position {_actorPosition}");
        var target = new Vector3(_actorPosition.x, ENEMY_CENTER, _actorPosition.z);

        var rotate = Quaternion.LookRotation(target - transform.position);
        //Debug.Log($"Actor rotation {rotate}");
        transform.rotation = Quaternion.RotateTowards(transform.rotation, rotate, Time.deltaTime * _rotationSpeed);
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * _speed);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sandbox") || collision.gameObject.CompareTag("Enemy"))
        {
            return;
        }
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log($"Enemy neutralized by {collision.gameObject.name}");
            Destroy(gameObject);
            Debug.Log($"Enemy revived");
            _enemySpawner.SpawnEnemy();
        }
    }
}
