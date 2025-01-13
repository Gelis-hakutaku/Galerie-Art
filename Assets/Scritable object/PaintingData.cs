using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PaintingData", menuName = "Scriptable Object/PaintingData", order = 2)]
public class PaintingData : ScriptableObject
{
    [Header ("UI Data")]
    [SerializeField] private Sprite sprite;
    [SerializeField] private string paintName;
    [SerializeField] private string date;
    [SerializeField] private string painter;



    [Header("Frame Data")]
    [SerializeField] private float height;
    [SerializeField] private float width;
}
