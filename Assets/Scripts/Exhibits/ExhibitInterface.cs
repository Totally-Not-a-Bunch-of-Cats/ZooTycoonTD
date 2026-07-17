using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExhibitInterface : MonoBehaviour
{

    [SerializeField]
    Exhibit exhibit;
    

    // Start is called before the first frame update
    void Start()
    {
        exhibit.exhibitEffect.exhibitInterface = this;
    }

    // Update is called once per frame
    void Update()
    {
        exhibit.exhibitEffect.OnGameUpdated();
    }

    void OnCollisionEnter(Collision collision)
    {
        exhibit.exhibitEffect.OnExhibitEnter(collision);
    }

    void OnCollisionExit(Collision collision)
    {
        exhibit.exhibitEffect.OnExhibitExited(collision);
    }

    public void ActivateAbility()
    {
        exhibit.exhibitEffect.OnAbilityActivated();
    }

    public void StartCooldown(float time)
    {
        StartCoroutine(CooldownTimer(time));
        exhibit.exhibitEffect.OnCooldownStarted();
    }

    IEnumerator CooldownTimer(float time)
    {
        yield return new WaitForSeconds(time);
        exhibit.exhibitEffect.OnCooldownEnded();
    }
}
