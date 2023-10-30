using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject SpawnedAnt;
    private int spawnTimer;
    public GameObject Spawnlocation;
    static public int SpawnValue = 5;
    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += SpawnValue;

        if(spawnTimer >= 7500)
        {
            spawnTimer = 0;
            Instantiate(SpawnedAnt, Spawnlocation.transform);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ant")
        {
            spawnTimer = 0;
            enabled = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ant")
        {
            spawnTimer = 0;
            enabled = true;
        }
    }
}
