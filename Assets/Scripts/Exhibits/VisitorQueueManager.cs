using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class VisitorQueueManager : MonoBehaviour
{

    [SerializeField]
    protected float QueueTime = 0f;

    [HideInInspector]
    public ExhibitInterface ExhibitInterface {get; set;}

    public virtual void QueueVisitor(Visitor visitor)
    {
        Debug.Log("This Queue Manager Didn't Implement An On Queue Method");
    }

    public void StartVisitTimer(float time, Action onTimerExpire)
    {
        StartCoroutine(VisitTimer(time, onTimerExpire));
    }

    IEnumerator VisitTimer(float time, Action onTimerExpire)
    {
        yield return new WaitForSeconds(time);
        onTimerExpire();
    }
}
