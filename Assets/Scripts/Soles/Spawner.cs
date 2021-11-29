using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject soles;
    public GameObject soles2;
    public GameObject bombas;

    public float xBounds, yBound;

    void Start()
    {
        StartCoroutine(SpawnRandomGameObject());
    }

    IEnumerator SpawnRandomGameObject()
    {
        yield return new WaitForSeconds(Random.Range(1, 2));

        if (Random.value < .3f)
            Instantiate(soles ,new Vector2(Random.Range(-xBounds,xBounds),yBound),Quaternion.identity);
        else if (Random.value<.6f)
        {
            Instantiate(soles2, new Vector2(Random.Range(-xBounds, xBounds), yBound), Quaternion.identity);
        }
        else
            Instantiate(bombas, new Vector2(Random.Range(-xBounds, xBounds), yBound), Quaternion.identity);

        StartCoroutine(SpawnRandomGameObject());
    }

}
