using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "VisitorWeights", menuName = "ScriptableObjects/Visitors/VisitorWeights", order = 1)]
public class VisitorWeights : ScriptableObject {

    public List<VisitorWeight> visitorWeights;

    public ExhibitGameInfo CalculateNextExhibit(List<ExhibitGameInfo> nearbyExhibits)
    {
        if(nearbyExhibits == null || nearbyExhibits.Count == 0) return null;
        return nearbyExhibits[0];
    }
}