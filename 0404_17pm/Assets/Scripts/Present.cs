using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Present : MonoBehaviour
{
    public GameObject Item;

    void Start()
    {
        InvokeRepeating("Spawnitem", 10, 1); //1초에 1번씩 Spawnitem()를 호출한다.
    }

    void Spawnitem()
    {
        float randomX = Random.Range(-23f, 19f);
        float randomZ = Random.Range(-23f, 19f);

        if (true)
        {
            GameObject item = (GameObject)Instantiate(Item, new Vector3(randomX, 10, randomZ), Quaternion.identity);
        }
    }
}
