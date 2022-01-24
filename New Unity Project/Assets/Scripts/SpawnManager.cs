using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private List<GameObject> prefabs = new List<GameObject>();
    [SerializeField]
    private float timestarted;
    void Start()
    {
        Invoke("Spawn", timestarted);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawn()
    {
        Instantiate(prefabs[0], transform.position + new Vector3(Random.Range(-11f, 11f), 0, 0), transform.rotation);
        //timestarted *= 0.95f;
        Invoke("Spawn", timestarted);
    }
    
}
