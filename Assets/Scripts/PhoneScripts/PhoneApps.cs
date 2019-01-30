using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneApps : MonoBehaviour
{
    private GameObject m_player;

    string whatApp;
    public GameObject phoneView;
    public GameObject credits;
    
    public AudioSource phoneSounds;
    public AudioClip tapSounds;
    private IEnumerator pauseForSound;

    void Start ()
    {
        m_player = GameObject.Find("MainPlayer");
	}
	
	void Update ()
    {
		
	}

    private void OnMouseDown()
    {
        whatApp = gameObject.name;

        switch (whatApp)
        {
            case "CameraClickArea":
                //m_player.OnPhoneClick("Camera");
                break;
            case "RecorderClickArea":
                //m_player.OnPhoneClick("Recorder");
                break;
            case "LightClickArea":
                //m_player.OnPhoneClick("Light");
                break;
            case "PayClickArea":
                //m_player.OnPhoneClick("Pay");
                break;
            case "CommunicationClickArea":
                Debug.Log("Clicked Comm");
                //Credits go here
                
                credits.SetActive(true);

                break;
            case "WeatherClickArea":
                Debug.Log("Clicked Weather");
                //Joke goes here
                break;
            default:
                break;
        }

        phoneSounds = GetComponent<AudioSource>();
        phoneSounds.PlayOneShot(tapSounds, 1);

        pauseForSound = PauseForSound();
        StartCoroutine(pauseForSound);

        //phoneView.SetActive(false);
    }

    private IEnumerator PauseForSound()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.3f);
            phoneView.SetActive(false);
        }
    }
}
