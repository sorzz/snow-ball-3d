using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    OVRInputButton OVRInputButton;

    public Text text;
    public float TimeCost;


    private void Start()
    {
        OVRInputButton = GameObject.Find("TrackedAlias").GetComponent<OVRInputButton>();
    }
    // Update is called once per frame
    void Update()
    {
        BuildTime();
    }

    void BuildTime()
    {
        if (TimeCost > 0)
        {
            TimeCost -= Time.deltaTime;
            text.text = "남은 시간 " + string.Format("{0:N2}", TimeCost);
        }
        else
        {
            OVRInputButton.inReady = false;
            text.text = "더이상 건설할 수 없습니다!";
            Invoke("delete", 2);

        }
    }
    void delete()
    {
        gameObject.SetActive(false);
        // 이거 코루틴으로 짜서 더이상건설x -> 싸우세요 -> 지워지기 해도 될듯.
    }

}
