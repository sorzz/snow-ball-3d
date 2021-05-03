using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBall : MonoBehaviour
{
    Vector3 oldPosition;
    Vector3 currentPosition;

    // Start is called before the first frame update
    void Start()
    {
        oldPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("tellVector", 1, 0.5f);
    }

    void tellVector()
    {
        currentPosition = transform.position;
        var distance = (currentPosition - oldPosition);
        var velocity = distance / Time.deltaTime;
        oldPosition = currentPosition;

        Debug.Log($"Kinematic Object's Velocity: {velocity}");
    }
}
