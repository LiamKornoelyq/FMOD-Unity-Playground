using UnityEngine;

public class upperPlatform1 : MonoBehaviour
{
    private Soundtrack musicTrigger;

    private void Start()
    {
        musicTrigger = GameObject.Find("Soundtrack").GetComponent<Soundtrack>();
    }

    private void OnTriggerEnter(Collider other)
    {
        musicTrigger.changeSparkleSpeed(2);
    }

    private void OnTriggerExit(Collider other)
    {
        musicTrigger.changeSparkleSpeed(4);
    }
}
