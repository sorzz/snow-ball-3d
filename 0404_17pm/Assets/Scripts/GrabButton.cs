using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zinnia.Action;


public class GrabButton : BooleanAction
{
    public OVRInput.Controller controller;
    public OVRInput.Button button;

    void Update()
    {
        //이거 반환 왜하는거였지 Grab에서 잡았따고 true값 달라고?
        Receive(OVRInput.Get(button, controller));
    }
}
