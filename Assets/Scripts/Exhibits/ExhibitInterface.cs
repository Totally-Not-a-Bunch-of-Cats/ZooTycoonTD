using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExhibitInterface : MonoBehaviour
{

    [SerializeField]
    public int VisitorLimit {get;}

    [SerializeField]
    ExhibitEffect exhibitEffect;

    [SerializeField]
    ExhibitAssetInfo exhibitAssetInfo;

    [SerializeField]
    ExhibitGameInfo exhibitGameInfo;

    [HideInInspector]
    public List<Visitor> VisitorQueue {get; private set;}

    [HideInInspector]
    public bool AcceptingVisitors  {get; set;} = true;
    
    void Start()
    {
        exhibitEffect.ExhibitInterface = this;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(IsCollisionAVisitor(collision) && AcceptingVisitors) EnqueueVisitor(GetVisitorFromCollision(collision));
    }

    public bool IsCollisionAVisitor(Collision collision)
    {
        return collision.gameObject.TryGetComponent<Visitor>(out Visitor visitor);
    }

    public Visitor GetVisitorFromCollision(Collision collision)
    {
        if(IsCollisionAVisitor(collision)) return collision.gameObject.GetComponent<Visitor>();
        return null;
    }

    public void EnqueueVisitor(Visitor visitor)
    {
        if(VisitorQueue.Count + 1 < VisitorLimit){
        VisitorQueue.Add(visitor);
        exhibitEffect.VisitorQueued(visitor);
        visitor.enabled = false;
        }
    }

    public void DequeueVisitor(Visitor visitor)
    {
        visitor.enabled = true;
        VisitorQueue.Remove(visitor);
    }

    public void DequeueAllVisitors()
    {
        AcceptingVisitors = false;
        foreach(Visitor visitor in VisitorQueue)
        {
            DequeueVisitor(visitor);
        }
        AcceptingVisitors = true;
    }
}
