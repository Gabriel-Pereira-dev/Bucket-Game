using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public float interval = 1.0f;
    private float cooldown = 0f;
    public List<GameObject> prefabs;
    public Vector3 spawnPoint = new Vector3(0,0,0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!GameManager.Instance.isGameActive){
            return;
        }
            cooldown -= Time.deltaTime;
            if(cooldown <= 0){
                cooldown = interval;
                SpawnBall();
            }
        
    }

    void SpawnBall(){
        int prefabIndex = Random.Range(0,prefabs.Count);
        GameObject prefab = prefabs[prefabIndex];
        Quaternion rotation = prefab.transform.rotation;
        float limit = GameManager.Instance.gameWidth /2;
        float x = Random.Range(-limit,limit);
        Vector3 position = spawnPoint;
        position.x = x;
        Instantiate(prefab,position,rotation);
    }
}
