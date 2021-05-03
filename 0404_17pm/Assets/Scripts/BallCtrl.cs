using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCtrl : MonoBehaviour
{
    public GameObject snowball;
    public ParticleSystem particle;


    void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector3 moveVec = new Vector3(1,0,0);
        transform.Translate(moveVec * 0.01f, Space.World);
    }

    public void particlePlay()
    {
        Debug.Log("여기왔엉 파티클플레이이잉");
        particle.Play();
    }
}
