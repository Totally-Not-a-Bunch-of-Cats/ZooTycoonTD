using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedVisitExhibit : VisitorQueueManager
{

    public override void QueueVisitor(Visitor visitor)
    {
        if( QueueTime == 0f){ Debug.Log("You forgot to set a visit length"); return;}
        StartVisitTimer(QueueTime, () => ExhibitInterface.DequeueVisitor(visitor));
    }
}
