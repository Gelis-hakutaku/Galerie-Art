using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//show or hide the canvas

public class ShowDescription : MonoBehaviour
{
    [SerializeField] private Canvas description;

    private bool active;

    private void Start()
    {
        active = false;
    }
    public void ToggleDescription()
    {
        active = !active;
        description.gameObject.SetActive(active);
    }
}
