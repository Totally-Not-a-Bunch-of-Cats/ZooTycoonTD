using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ExhibitEffect : MonoBehaviour
{
    public ExhibitInterface exhibitInterface;

    [SerializeField] float entranceFee;

    List<Visitor> visitors;

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

    public void EarnEntranceFee(Collision collision)
    {
        if (!IsCollisionAVisitor(collision)) return;

        Visitor visitor = GetVisitorFromCollision(collision);
        float actualEarnings = visitor.ChargeVisitor(entranceFee);
        ResourceEvent resourceEvent = new ResourceEvent();
        resourceEvent.cash = actualEarnings;
        GameManager.Instance.resourceManager.AddCash(resourceEvent);
    }

    public bool IsCollisionAVisitor(Collision collision)
    {
        return collision.gameObject.tag == "Visitor";
    }

    public Visitor GetVisitorFromCollision(Collision collision)
    {
        return collision.gameObject.GetComponent<Visitor>();
    }

    public void StartCooldown(float time)
    {
        StartCoroutine(CooldownTimer(time));
        OnCooldownStarted();
    }

    IEnumerator CooldownTimer(float time)
    {
        yield return new WaitForSeconds(time);
        OnCooldownEnded();
    }
}
