using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Exhibit : ScriptableObject
{
    [SerializeField]
    public ExhibitInterface exhibitInterface;

    public GameObject ExhabitPrefab;

    public void OnExhibitEnter(Collision collision)
    {
        
    }

    public void OnExhibitExited(Collision collision)
    {
        
    }

    public void OnCooldownStarted()
    {
        
    } 

    public void OnCooldownEnded()
    {
        
    }

    public void OnAbilityActivated()
    {
        
    }

    public void OnGameUpdated()
    {
    
    }
}
