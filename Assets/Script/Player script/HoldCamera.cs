using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script attach itself to the player's child designed to be the camera position
public class HoldCamera : MonoBehaviour
{
    [SerializeField] private Transform cameraPosition;

    private void LateUpdate()
    {
        transform.position = cameraPosition.position;
    }
}
