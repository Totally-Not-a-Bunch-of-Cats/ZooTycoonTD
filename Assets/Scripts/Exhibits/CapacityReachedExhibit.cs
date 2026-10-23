using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapacityReachedExhibit : VisitorQueueManager
{
    public override void QueueVisitor(Visitor visitor)
    {
        if(ExhibitInterface.VisitorQueue.Count < ExhibitInterface.VisitorLimit) return;
        StartVisitTimer(QueueTime, ExhibitInterface.DequeueAllVisitors);
    }
}
