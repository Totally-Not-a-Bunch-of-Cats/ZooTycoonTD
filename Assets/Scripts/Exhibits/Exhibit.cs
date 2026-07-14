using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exhibit : MonoBehaviour
{

    [SerializeField]
    ExhibitInfo exhibitInfo;

    [SerializeField]
    ExhibitEffect exhibitEffect;

    // Start is called before the first frame update
    void Start()
    {
        exhibitEffect.exhibit = this;
    }

    // Update is called once per frame
    void Update()
    {
        exhibitEffect.OnGameUpdated();
    }

    void OnCollisionEnter(Collision collision)
    {
        exhibitEffect.OnExhibitEnter(collision);
    }

    void OnCollisionExit(Collision collision)
    {
        exhibitEffect.OnExhibitExited(collision);
    }

    public void ActivateAbility()
    {
        exhibitEffect.OnAbilityActivated();
    }

    public void StartCooldown(float time)
    {
        StartCoroutine(CooldownTimer(time));
        exhibitEffect.OnCooldownStarted();
    }

    IEnumerator CooldownTimer(float time)
    {
        yield return new WaitForSeconds(time);
        exhibitEffect.OnCooldownEnded();
    }
}
