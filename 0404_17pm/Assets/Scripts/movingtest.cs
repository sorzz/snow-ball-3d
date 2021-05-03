using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingtest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        float head_angle = transform.eulerAngles.y;
        float radian = (90.0f - head_angle) * Mathf.PI / 180;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            Vector3 moveVec = new Vector3(Mathf.Cos(radian), 0, Mathf.Sin(radian));

            Debug.Log(head_angle);
            Debug.Log(moveVec);


            transform.Translate(moveVec * 1,Space.World);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector3 moveVec = new Vector3(Mathf.Cos(90 - head_angle), 0, - Mathf.Sin(90 - head_angle));
            Debug.Log(head_angle);
            Debug.Log(moveVec);
            transform.Translate(moveVec * 1,Space.World);
           
        }   

    }
}
