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
        if (collision.gameObject.CompareTag("Sandbox") || collision.gameObject.CompareTag("Enemy"))
        {
            return;
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.gameObject.GetComponent<Renderer>().material.color == gameObject.GetComponent<Renderer>().material.color)
            {
                Destroy(gameObject);
                _figureSpawner.SpawnEnemy();
            }
        }
    }
}
