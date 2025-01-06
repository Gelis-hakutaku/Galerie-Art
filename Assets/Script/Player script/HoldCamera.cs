using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldCamera : MonoBehaviour
{
    [SerializeField] private Transform cameraPosition;

    private void LateUpdate()
    {
        transform.position = cameraPosition.position;
    }
}
