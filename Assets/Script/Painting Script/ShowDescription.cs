using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDescription : MonoBehaviour
{
    [SerializeField] private Canvas description;

    public void ToggleDescription()
    {
        description.enabled = !description.enabled;
        Debug.Log("clic");
    }
}
