using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    [SerializeField]
    bool isOpen = false;

    
    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("IsOpen", isOpen);
    }

    public void Open()
    {
        isOpen = true;
        anim.SetBool("IsOpen", isOpen);
    }

    public void Close()
    {
        isOpen = false;
        anim.SetBool("IsOpen", isOpen);
    }

    public void ToggleDoor()
    {
        if (isOpen)
        {
            Close();
        } else
        {
            Open();
        }
    }
}
