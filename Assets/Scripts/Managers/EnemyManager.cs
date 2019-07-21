using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;


    void Start ()
    {
        InvokeRepeating ("Spawn", spawnTime, spawnTime);
    }


    void Spawn ()
    {
        if(playerHealth.currentHealth <= 0f)
        {
            return;
        }

        // int spawnPointIndex = Random.Range (0, spawnPoints.Length);

        Instantiate (enemy1, spawnPoints[0].position, spawnPoints[0].rotation);
        Instantiate (enemy2, spawnPoints[1].position, spawnPoints[1].rotation);
        Instantiate (enemy3, spawnPoints[2].position, spawnPoints[2].rotation);
    }
}
