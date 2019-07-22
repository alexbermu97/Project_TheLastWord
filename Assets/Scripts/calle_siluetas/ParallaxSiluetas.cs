using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxSiluetas : MonoBehaviour
{

    class PoolObject
    {
        public Transform transform;
        public bool inUse;
        public PoolObject(Transform t) { transform = t; }
        public void Use() { inUse = true; }
        public void Dispose() { inUse = false; }
    }

   

    public GameObject Prefab;
    public int poolSize;
    public float Speed;
    public float spawnRate;

    
    public Vector3 defaultSpawnPos;
    public bool spawnImmediate;
    public Vector3 immediateSpawnPos;
    Vector2 targetAspectRatio;

    float spawnTimer;
    float targetAspect;
    PoolObject[] poolObjects;
   


    void Awake()
    {
        Configure();
    }

    // Use this for initialization
    void Start()
    {
        

    }
  
    void gamestart()
    {
        for (int i = 0; i < poolObjects.Length; i++)
        {
            poolObjects[i].Dispose();
          
        }
        if (spawnImmediate)
        {
            SpawnImmediate();
        }

    }
    // Update is called once per frame
    void Update()
    {
        

        Shift();
        spawnTimer += Time.deltaTime;
        if (spawnTimer > spawnRate)
        {
            Spawn();
            spawnTimer = 0;
        }

    }
    void Configure()
    {
        targetAspect = targetAspectRatio.x / targetAspectRatio.y;
        poolObjects = new PoolObject[poolSize];
        for (int i = 0; i < poolObjects.Length; i++)
        {

            GameObject go = Instantiate(Prefab) as GameObject;
            Transform t = go.transform;
            t.SetParent(transform);
           
            poolObjects[i] = new PoolObject(t);
            
        }

        if (spawnImmediate)
        {
            SpawnImmediate();
        }

    }
    void Spawn()
    {
        Transform t = GetPoolObject();
        if (t == null) return;
        Vector3 pos = Vector3.zero;
        pos.x = defaultSpawnPos.x;
        pos.y = defaultSpawnPos.y;
        t.position = pos;
        
    }

    void SpawnImmediate()
    {
        Transform t = GetPoolObject();
        if (t == null) return;
        Vector3 pos = Vector3.zero;
        pos.x = immediateSpawnPos.x;
        pos.y = immediateSpawnPos.y;
        t.position = pos;
        
        Spawn();
    }

    void Shift()
    {
        for (int i = 0; i < poolObjects.Length; i++)
        {
            poolObjects[i].transform.localPosition += -Vector3.right * Speed * Time.deltaTime;
            CheckDisposeObject(poolObjects[i]);
        }
    }
    void CheckDisposeObject(PoolObject poolObject)
    {
        if (poolObject.transform.position.x < -defaultSpawnPos.x)
        {
            poolObject.Dispose();

        }
    }
    Transform GetPoolObject()
    {
        for (int i = 0; i < poolObjects.Length; i++)
        {
            if (!poolObjects[i].inUse)
            {
                poolObjects[i].Use();
                return poolObjects[i].transform;
            }
        }
        return null;
    }
}