using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExhibitInterface : MonoBehaviour
{

    [SerializeField]
    Exhibit exhibit;
    ExhibitInfo exhibitInfo;
    

    // Start is called before the first frame update
    void Start()
    {
        exhibit.exhibitInterface = this;
    }

    // Update is called once per frame
    void Update()
    {
        exhibit.OnGameUpdated();
    }

    void OnCollisionEnter(Collision collision)
    {
        exhibit.OnExhibitEnter(collision);
    }

    void OnCollisionExit(Collision collision)
    {
        exhibit.OnExhibitExited(collision);
    }

    public void ActivateAbility()
    {
        exhibit.OnAbilityActivated();
    }

    public void StartCooldown(float time)
    {
        StartCoroutine(CooldownTimer(time));
        exhibit.OnCooldownStarted();
    }

    IEnumerator CooldownTimer(float time)
    {
        yield return new WaitForSeconds(time);
        exhibit.OnCooldownEnded();
    }
}
