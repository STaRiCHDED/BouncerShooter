using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FigureController : MonoBehaviour
{
    private FigureSpawner _figureSpawner;
    private Camera _actor;
    private Vector3 _actorPosition;
    
    void Start()
    {
        _figureSpawner = FindObjectOfType<FigureSpawner>();
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        var collisionObject = collision.gameObject.GetComponent<Renderer>();
        var current = gameObject.GetComponent<Renderer>();
        if (collision.gameObject.CompareTag("Sandbox") || collision.gameObject.CompareTag("Enemy"))
        {
            return;
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collisionObject.material.color == current.material.color)
            {
                Destroy(gameObject);
                _figureSpawner.SpawnEnemy();
            }
        }
    }
}
