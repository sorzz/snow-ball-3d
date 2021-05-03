using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machine : MonoBehaviour
{
    public GameObject snowball;
    public Transform ballPos;
    
    void Start()
    {
        InvokeRepeating("Spawnitem", 1, 2); //1초에 1번씩 Spawnitem()를 호출한다.
    }

    void Update()
    {
         
    }

    void Spawnitem()
    {
        Instantiate(snowball, ballPos.position, ballPos.rotation);
    }

}
