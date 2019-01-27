using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractive : MonoBehaviour
{
    public List<GameObject> Interactables;

    public string GetInteractableQuip(GameObject worldObject, string clickedApp)
    {
        foreach (var thing in Interactables)
        {
            if (thing == worldObject)
            {
                switch (clickedApp)
                {
                    case "":
                    default:
                        return null;
                }
            }
        }
        return null;
    }

    // Use this for initialization
    void Start()
    {
        Interactables.Add(GameObject.Find("TacoVendorClick"));
        Interactables.Add(GameObject.Find("ResidentialAlleyClick"));

        Interactables.Add(GameObject.Find("LatinMusicDoor"));
        Interactables.Add(GameObject.Find("HouseOfBluesDoor"));
        Interactables.Add(GameObject.Find("TraderJanesDoor"));
        Interactables.Add(GameObject.Find("ChowsChowDoor"));
        Interactables.Add(GameObject.Find("CommercialAlleyClick"));

        Interactables.Add(GameObject.Find("StadiumClick"));
        Interactables.Add(GameObject.Find("WheelClick"));
        Interactables.Add(GameObject.Find("BeachClick"));
    }

    // Update is called once per frame
    void Update ()
    {
		
	}
}
