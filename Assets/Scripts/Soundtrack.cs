using Unity.VisualScripting;
using UnityEngine;

public class Soundtrack : MonoBehaviour
{
    private static FMOD.Studio.EventInstance backgroundMusic;

    GameObject player;
    GameObject radio;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.Find("PlayerCapsule");
        radio = GameObject.Find("Recorder");

        backgroundMusic = FMODUnity.RuntimeManager.CreateInstance("event:/backgroundMusic");
        backgroundMusic.start();
    }

    // Update is called once per frame
    void Update()
    {
        //cut music when player gets close to the radio
        float distance = Vector3.Distance(player.transform.position, radio.transform.position);
        backgroundMusic.setParameterByName("musicVol", distance);
    }

    public void changeSparkleSpeed(int speed)
    {
        backgroundMusic.setParameterByName("sparkleSpeed", speed);
    }
}
