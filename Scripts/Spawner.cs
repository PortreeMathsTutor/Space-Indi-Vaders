using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab1;
    public GameObject prefab2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] gos1;
        gos1 = GameObject.FindGameObjectsWithTag("Enemy");
        if (gos1.Length < 3) { Instantiate(prefab1, transform.position, Quaternion.identity); }

        GameObject[] gos2;
        gos2 = GameObject.FindGameObjectsWithTag("Barrier");
        if (gos2.Length < 1) { Instantiate(prefab2, transform.position, Quaternion.identity); }
    }
}
