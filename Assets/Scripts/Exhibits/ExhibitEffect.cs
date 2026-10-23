using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ExhibitEffect : MonoBehaviour
{
    [HideInInspector]
    public ExhibitInterface ExhibitInterface {get; set;}

    [SerializeField]
    VisitorQueueManager visitorQueueManager;

    public void Start()
    {
        visitorQueueManager.ExhibitInterface = ExhibitInterface;
    }

    public void VisitorQueued(Visitor visitor)
    {
        visitorQueueManager.QueueVisitor(visitor);
        VisitExhibit(visitor);
    }

    public virtual void VisitExhibit(Visitor visitor)
    {
        Debug.Log("This effect didn't implement an effect: " + GetType().Name);
    }

}
