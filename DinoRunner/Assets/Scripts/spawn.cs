using UnityEngine;
using System.Collections;

public class spaw : MonoBehaviour
{
   [SerializeField] private GameObject cactusPrefab;
   [SerializeField] private float intervalToSpawn;

private void Start()
    {
        StartCoroutine(SpawnCactus(intervalToSpawn));
    }

    private IEnumerator SpawnCactus(float t)
    {
        yield return new WaitForSeconds(t);
        GameObject cactus = Instantiate(cactusPrefab);

        cactus.transform.position = transform.position;
        StartCoroutine(SpawnCactus(t));

    }
}
