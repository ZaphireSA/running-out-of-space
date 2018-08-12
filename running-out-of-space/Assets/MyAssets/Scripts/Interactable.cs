using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour {

    public float maxDistance = 4f;
    public bool isActive = true;

    private void Update()
    {
        if (!isActive) return;
        if (Input.GetKeyDown(KeyCode.E)) {
            var player = FindObjectOfType<Player>();
            if (player != null && Vector3.Distance(transform.position, player.transform.position) < maxDistance)
            {
                this.Interact();
            }
        }
    }

    public virtual void Interact()
    {

    }
}
