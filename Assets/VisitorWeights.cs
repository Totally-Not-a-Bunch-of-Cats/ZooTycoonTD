using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "VisitorWeights", menuName = "ScriptableObjects/VisitorWeights", order = 0)]
public class VisitorWeights : ScriptableObject {

    public List<VisitorWeight> visitorWeights;

    public ExhibitInfo CalculateNextExhibit(List<ExhibitInfo> nearbyExhibits)
    {
        if(nearbyExhibits == null || nearbyExhibits.Count == 0) return null;
        return nearbyExhibits[0];
    }
}