using UnityEngine;
using Zinnia.Action;

public class OVRInputButton : BooleanAction
{
    public OVRInput.Controller controller;
    public OVRInput.Button button;

    void Update()
    {
        Receive(OVRInput.Get(button, controller));
    }
}
