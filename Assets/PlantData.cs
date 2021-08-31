using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="plant data", menuName ="PlantData",order =60)]
public class PlantData : ScriptableObject
{
    public enum THREAT { None,Low,Moderate,High}
    [SerializeField]
    private string plantName;
    [SerializeField]
    private THREAT plantThreat;
    [SerializeField]
    private Texture icon;

    public string Name { get { return plantName; } }
    public THREAT PlantThreat { get { return PlantThreat; } }
    public Texture Icon { get { return Icon; } }
}
