using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ExhibitGameInfo", menuName = "ScriptableObjects/Exhibits/ExhibitGameInfo", order = 3)]
public class ExhibitGameInfo : ScriptableObject
{
    [SerializeField]
    ExhibitType exhibitType;

    [SerializeField]
    AnimalType animalType;

    [SerializeField]
    String exhibitName;
    
}