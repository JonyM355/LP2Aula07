using UnityEngine;

public class ConsoleMessages : MonoBehaviour
{
    private EventMaster em;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        em = GetComponent<EventMaster>();
    }

    private void PrintOnConsole(char k)
    {
        Debug.Log($"Key pressed: {k}");
    }

    private void OnEnable()
    {
        em.KeyPress += PrintOnConsole;
    }

    private void OnDisable()
    {
        em.KeyPress -= PrintOnConsole;
    }
}
