using UnityEngine;

public class upperPlatform2 : MonoBehaviour
{
    private Soundtrack musicTrigger;

    private void Start()
    {
        musicTrigger = GameObject.Find("Soundtrack").GetComponent<Soundtrack>();
    }

    private void OnTriggerEnter(Collider other)
    {
        musicTrigger.changeSparkleSpeed(3);
    }

    private void OnTriggerExit(Collider other)
    {
        musicTrigger.changeSparkleSpeed(4);
    }
}
