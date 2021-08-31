using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plant : MonoBehaviour
{
    [SerializeField]
    private PlantData info;
    private SetPlantInfo setPlantInfo;

    private void Start()
    {
        setPlantInfo = GameObject.FindGameObjectWithTag("PlantInfo").GetComponent<SetPlantInfo>();
    }

    private void OnMouseDown()
    {
        setPlantInfo.OpenPlantPanel();
        setPlantInfo.plantName.text = info.Name;
        setPlantInfo.threatLevel.text = info.PlantThreat.ToString();
        setPlantInfo.plantIcon.GetComponent<RawImage>().texture = info.Icon;


    }

}
