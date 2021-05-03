using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRemove : MonoBehaviour
{
    public bool isGrabbed = false;
      
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("닿깅했다..!" + other.gameObject.name + isGrabbed);
        if (other.gameObject.tag == "SnowBall" && isGrabbed)
        {
            Debug.Log("스노우 볼이다..!");
            //other.gameObject.SetActive(false);
            BallCtrl ballCtrl = other.gameObject.GetComponent<BallCtrl>();
            ballCtrl.snowball.SetActive(false);
            ballCtrl.particlePlay();
        }
    }

    public void setisGrabbed(bool isa)
    {
        isGrabbed = isa;
    }
}
