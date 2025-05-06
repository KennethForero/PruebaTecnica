using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using System.Linq;

public class Spawner : MonoBehaviour
{
    public TextMeshProUGUI countText;

    public GameObject prefabToSpawn;
    public int maxSpawn = 10;
    public float timeGenerator=2f;

    private float minX = -5;
    private float maxX = 5;


    private float minZ = -5;
    private float maxZ = 5;

    public float yHight = 0f;

    public List<GameObject> spawnList = new List<GameObject>();

    private void Start()
    {
        StartCoroutine(Loop());

    }
    IEnumerator Loop()
    {
        while (true) {

            UpdateCount();


            if (spawnList.Count <maxSpawn)
            {
                Vector3 spawnPos = new Vector3(Random.Range(minX,maxX),yHight,(Random.Range(minZ,maxZ)));

                GameObject newObject = Instantiate(prefabToSpawn,spawnPos, Quaternion.identity);

                spawnList.Add( newObject );
                UpdateCount();
            }
            yield return new WaitForSeconds(timeGenerator);  
        
        
        }

    }
    public void UpdateCount()
    {

        countText.text = "Objetos Activos: " + spawnList.Count;
    }

    public void RemoveFromList(GameObject obj)
    {
        spawnList.Remove(obj);
    }




}
