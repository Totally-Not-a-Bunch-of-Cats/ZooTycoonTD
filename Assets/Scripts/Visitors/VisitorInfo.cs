using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "VisitorInfo", menuName = "ScriptableObjects/VisitorInfo", order = 1)]
public class VisitorInfo : ScriptableObject 
{

    [SerializeField]
    VisitorWeights visitorWeights;

    [SerializeField]
    float startingCash;
}
