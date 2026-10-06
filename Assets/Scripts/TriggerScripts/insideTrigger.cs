using UnityEngine;

public class insideTrigger : MonoBehaviour
{
    private Soundtrack musicTrigger;

    private void Start()
    {
        musicTrigger = GameObject.Find("Soundtrack").GetComponent<Soundtrack>();
    }

    private void OnTriggerEnter(Collider other)
    {
        musicTrigger.changeSparkleSpeed(1);
    }

    private void OnTriggerExit(Collider other)
    {
        musicTrigger.changeSparkleSpeed(4);
    }
}
