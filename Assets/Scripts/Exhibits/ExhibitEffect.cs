using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ExhibitEffect : ScriptableObject
{
    public ExhibitInterface exhibitInterface;

    public virtual void OnExhibitEnter(Collision collision)
    {
        Debug.Log("This exhibit effect did not implement an OnExhibitEnter");
    }

    public virtual void OnExhibitExited(Collision collision)
    {
        Debug.Log("This exhibit effect did not implement an OnExhibitExited");
    }

    public virtual void OnCooldownStarted()
    {
        Debug.Log("This exhibit effect did not implement an OnCooldownStarted");
    } 

    public virtual void OnCooldownEnded()
    {
        Debug.Log("This exhibit effect did not implement an OnCooldownEnded");
    }

    public virtual void OnAbilityActivated()
    {
        Debug.Log("This exhibit effect did not implement an OnAbilityActivated");
    }

    public virtual void OnGameUpdated()
    {
        // Not loggging for every update lol
    }
}
