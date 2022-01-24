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
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawn()
    {
        Instantiate(prefabs[Random.Range(0,prefabs.Count)], transform.position + new Vector3(Random.Range(-10f, 10f), 0, 0), transform.rotation);
        if(timestarted > .2f) timestarted *= 0.95f;

        Invoke("Spawn", timestarted);
    }
    
}
