using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSwitch : Interactable
{


    public override void Interact()
    {
        base.Interact();
        GetComponentInParent<Door>().ToggleDoor();
    }
}
