using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private GameObject landingAreaPrefab;

    [SerializeField]
    private GameObject playerSpawnPoints;

    private bool respawn;
    private Transform[] spawnPoints;
    

    private void Start()
    {
        spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();
    }

    private void Update()
    {
        if (respawn)
        {
            Respawn();

            respawn = false;
        }
    }

    private void Respawn()
    {
        int index = Random.Range(1, spawnPoints.Length);

        transform.position = spawnPoints[index].position;
    }

    private void OnFindClearArea()
    {
        Invoke("DropFlare", 3f);
    }

    private void DropFlare()
    {
        Instantiate(landingAreaPrefab, transform.position, transform.rotation);
    }
}