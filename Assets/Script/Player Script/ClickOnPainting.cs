using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//enable the description panel on the painting with a left click 
public class ClickOnPainting : MonoBehaviour
{
    [SerializeField] private Transform playerPosition;
    [SerializeField] private LayerMask painting;
    [SerializeField] private float range;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) 
                && Physics.Raycast(playerPosition.position, playerPosition.forward, out RaycastHit hit, range, painting))
        {
            hit.collider.GetComponentInChildren<ShowDescription>().ToggleDescription();
        }
    }
}
