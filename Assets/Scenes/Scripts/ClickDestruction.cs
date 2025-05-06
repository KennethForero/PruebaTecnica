using UnityEngine;

public class ClickDestruction : MonoBehaviour
{
    private Spawner spawnerScript;

    private void Start()
    {
        spawnerScript = FindAnyObjectByType<Spawner>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                Destroy(hit.transform.gameObject);
                spawnerScript.UpdateCount();
            }
        }
    }
}
