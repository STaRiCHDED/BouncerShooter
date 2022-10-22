using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] 
    private GameObject _actor;
    private void Start()
    {
        for(int i =0;i<5;i++) SpawnEnemy();
    }
    public void SpawnEnemy()
    {
        var newActor = Instantiate(_actor);
        newActor.transform.position = new Vector3(Random.Range(-15,15), _actor.transform.localScale.y/2 + 0.5f, Random.Range(-15,15));
    }
}
