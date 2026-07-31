using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinExhibitEffect : ExhibitEffect
{
    public override void OnExhibitExited(Collision collision)
    {
        //Give visitors cold status (makes them walk slower)
        //other effects
    }

    public override void OnAbilityActivated()
    {
        //start cool down
        //triggure show. Shows rolls a coolness check then gets moeny based on that roll per
        //second for the duration of the show
    }
}
