using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnPainting : MonoBehaviour
{
    [SerializeField] private Transform playerPosition;
    [SerializeField]private LayerMask painting;

    void Update()
    {
        //Vector3 forward = playerPosition.TransformDirection(Vector3.forward);
        if (Input.GetKeyDown(KeyCode.Mouse0) 
                && Physics.Raycast(playerPosition.position, playerPosition.forward, out RaycastHit hit, 10, painting))
        {
            Debug.Log(hit.collider.name);
            hit.collider.GetComponentInChildren<ShowDescription>().ToggleDescription();
        }
    }
}
