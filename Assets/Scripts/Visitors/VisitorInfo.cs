using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "VisitorInfo", menuName = "ScriptableObjects/Visitors/VisitorInfo", order = 0)]
public class VisitorInfo : ScriptableObject 
{

    [SerializeField]
    VisitorWeights visitorWeights;

    [SerializeField]
    float startingCash;
}
