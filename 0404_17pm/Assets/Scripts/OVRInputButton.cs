using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OVRInputButton : MonoBehaviour
{
    public GameObject headset;

    public GameObject snowball;
    public GameObject wall;
    public Transform ballPos;

    public bool inReady = true;

    void Update()
    {
        Move();
        Ball();
        Wall();
    }

    private void Ball()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            Instantiate(snowball, ballPos.position, ballPos.rotation);
        }
    }

    private void Wall()
    {
        if (OVRInput.GetDown(OVRInput.Button.Two) && inReady)
        {
            Instantiate(wall, ballPos.position, ballPos.rotation);
        }
    }
    private void Move()
    {
        //if (OVRInput.Get(OVRInput.Button.PrimaryThumbstickLeft, controller))
        //{
        //    Debug.Log("왼쪽으로 가고 있다리~~");
        //    Vector3 moveDir = new Vector3(-15, 0, 0);
        //    transform.Translate(moveDir * Time.smoothDeltaTime);
        //}


        // 이렇게 하면 터치가 안되고 바로 막대기만 휘게 했을 때 작동이 안되긴하는데 알빠아님 씨발..
        Vector3 moveVec = Vector3.zero;

        if (OVRInput.Get(OVRInput.Touch.PrimaryThumbstick))
        {
            Vector2 ThumbDir = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);

            var absX = Mathf.Abs(ThumbDir.x);
            var absY = Mathf.Abs(ThumbDir.y);

            float head_angle = headset.transform.eulerAngles.y;
            float radian = (90.0f - head_angle) * Mathf.PI / 180;
            float radian1 =   head_angle * Mathf.PI / 180;

            if (absX > absY)
            {
                if (ThumbDir.x>0)
                {
                    moveVec = new Vector3(Mathf.Cos(radian1), 0, -Mathf.Sin(radian1));
                }
                else if (ThumbDir.x < 0)
                {
                    moveVec = new Vector3(-Mathf.Cos(radian1), 0, Mathf.Sin(radian1));
                }
            }
            else
            {
                if (ThumbDir.y > 0)
                {
                    moveVec = new Vector3(Mathf.Cos(radian), 0, Mathf.Sin(radian));
                }
                else if (ThumbDir.y < 0)
                {
                    moveVec = new Vector3(-Mathf.Cos(radian), 0, -Mathf.Sin(radian));
                }
            }

            transform.Translate(moveVec * 2 * Time.smoothDeltaTime);
        }
    }
}
