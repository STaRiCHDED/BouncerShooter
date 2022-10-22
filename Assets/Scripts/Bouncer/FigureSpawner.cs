using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FigureSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _actor;
    private void Start()
    {
        for(int i =0;i<10;i++) SpawnEnemy(); 
    }
    public void SpawnEnemy()
    {
        var newActor = Instantiate(_actor);
        newActor.transform.position = new Vector3(Random.Range(-20,20), _actor.transform.localScale.y/2+ 0.5f, Random.Range(-20,20));
    }
}
