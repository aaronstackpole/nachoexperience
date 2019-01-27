using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitlePlay : MonoBehaviour {

    public GameObject titleScreen;
    //private IEnumerator fadeTo;
    //public Material material;

    void Start () {

        
		
	}
	
	void Update () {
		
	}

    private void OnMouseDown()
    {
        titleScreen.SetActive(false);

        //fadeTo = FadeTo(material, 0, 0.5f);
        //StartCoroutine(fadeTo);
    }

    //// Define an enumerator to perform our fading.
    //// Pass it the material to fade, the opacity to fade to (0 = transparent, 1 = opaque),
    //// and the number of seconds to fade over.
    //IEnumerator FadeTo(Material material, float targetOpacity, float duration)
    //{

    //    // Cache the current color of the material, and its initiql opacity.
    //    Color color = material.color;
    //    float startOpacity = color.a;

    //    // Track how many seconds we've been fading.
    //    float t = 0;

    //    while (t < duration)
    //    {
    //        // Step the fade forward one frame.
    //        t += Time.deltaTime;
    //        // Turn the time into an interpolation factor between 0 and 1.
    //        float blend = Mathf.Clamp01(t / duration);

    //        // Blend to the corresponding opacity between start & target.
    //        color.a = Mathf.Lerp(startOpacity, targetOpacity, blend);

    //        // Apply the resulting color to the material.
    //        material.color = color;

    //        // Wait one frame, and repeat.
    //        yield return null;
    //    }
    //}
}
