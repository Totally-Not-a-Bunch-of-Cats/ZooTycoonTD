using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntervalVisitExhibit : VisitorQueueManager
{

    // Start is called before the first frame update
    void Start()
    {
      OnIntervalFinish();
    }

    public override void QueueVisitor(Visitor visitor)
    {
        return;
    }

    void OnIntervalFinish()
    {
        ExhibitInterface.DequeueAllVisitors();
        StartVisitTimer(QueueTime, OnIntervalFinish); 
    }
}
