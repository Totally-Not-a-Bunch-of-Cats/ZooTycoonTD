using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ExhibitInfo", menuName = "ScriptableObjects/ExhibitInfo", order = 2)]
public class ExhibitInfo : ScriptableObject
{
    [SerializeField]
    ExhibitType exhibitType;

    [SerializeField]
    AnimalType animalType;
    
}