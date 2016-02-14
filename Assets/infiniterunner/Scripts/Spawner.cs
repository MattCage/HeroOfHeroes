using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public GameObject[] objs; // Setto un array di oggetti da spawnare
    public float spawnTimeMin = 1.0f; // Setto un tempo minimo al quale spawnare oggetti
    public float spawnTimeMax = 2.0f; // Setto un tempo massimo entro il quale spawnare oggetti

    // All'avvio richiamo la funzione che spawna oggetti
    void Start () {
        Spawn();
	}

    // Funzione che gestisce lo spawn di oggetti
    void Spawn()
    {

        // Istanzio un oggetto a random dall'array, nella posizione e rotazione dello spawner stesso
        Instantiate(objs[Random.Range(0, objs.Length)], transform.position, Quaternion.identity);

        // Invoco questa stessa funzione in un tempo random
        Invoke("Spawn", Random.Range(spawnTimeMin, spawnTimeMax));

    }
	
}
