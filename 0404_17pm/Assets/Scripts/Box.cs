using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public int Health = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.tag == "SnowBall")
        //{
        //    Health -= 10;
        //    Destroy(collision.gameObject);
        //    if (Health == 0)
        //    {
        //        Destroy(gameObject);
        //    }
        //}
    }
}
