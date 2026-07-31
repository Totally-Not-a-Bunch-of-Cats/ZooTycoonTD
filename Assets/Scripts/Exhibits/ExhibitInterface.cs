using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExhibitInterface : MonoBehaviour
{

    [SerializeField]
    ExhibitEffect exhibitEffect;

    [SerializeField]
    public ExhibitAssetInfo exhibitAssetInfo;

    [SerializeField]
    public ExhibitGameInfo exhibitGameInfo;
    

    // Start is called before the first frame update
    void Start()
    {
        exhibitEffect.exhibitInterface = this;
    }

    // Update is called once per frame
    void Update()
    {
        exhibitEffect.OnGameUpdated();
    }

    void OnCollisionEnter(Collision collision)
    {
        exhibitEffect.OnExhibitEnter(collision);
        exhibitEffect.EarnEntranceFee(collision);
    }

    void OnCollisionExit(Collision collision)
    {
        exhibitEffect.OnExhibitExited(collision);
    }

    public void ActivateAbility()
    {
        exhibitEffect.OnAbilityActivated();
    }

    
}
