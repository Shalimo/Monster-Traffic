using System.Collections;
using UnityEngine;

public class SpawnCars : MonoBehaviour  
{
    public GameObject[] cars;
    private float[] positions = {-1.86f, -0.65f, 0.59f, 1.76f};

    void Start()
    {
        StartCoroutine(spawn());
    }

    IEnumerator spawn()
    {
        while(true)
        {
            Instantiate(
                cars[Random.Range(0, cars.Length)],
                new Vector2(positions[Random.Range(0, 4)], 6f),
                Quaternion.Euler(new Vector2(90, 180))
                );
            yield return new WaitForSeconds(0.6f);
        }
    }  
}
