using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnPainting : MonoBehaviour
{
    [SerializeField] private Transform playerPosition;
    [SerializeField]private LayerMask painting;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) 
                && Physics.Raycast(playerPosition.position, playerPosition.forward, out RaycastHit hit, 50, painting))
        {
            hit.collider.GetComponentInChildren<ShowDescription>().ToggleDescription();
        }
    }
}
