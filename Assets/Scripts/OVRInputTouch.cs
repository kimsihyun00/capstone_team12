using UnityEngine;
using Zinnia.Action;

public class OVRInputTouch : BooleanAction
{
    public OVRInput.Controller controller;
    public OVRInput.Touch touch;

    void Update()
    {
        Receive(OVRInput.Get(touch, controller));
    }
}
