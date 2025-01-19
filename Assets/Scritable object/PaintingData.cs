using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PaintingData", menuName = "Scriptable Object/PaintingData", order = 2)]
public class PaintingData : ScriptableObject
{
    [SerializeField] private string _description;

    public string Description
    {
        get => _description;
        set { _description = value; }
    }       
}
