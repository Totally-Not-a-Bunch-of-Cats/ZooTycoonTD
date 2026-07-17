using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Exhibit", menuName = "ScriptableObjects/Exhibits/Exhibit", order = 1)]
public class Exhibit : ScriptableObject
{
    public ExhibitEffect exhibitEffect;
    public ExhibitAssetInfo exhibitAssetInfo;

    public ExhibitGameInfo exhibitGameInfo;
}
