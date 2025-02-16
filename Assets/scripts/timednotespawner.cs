using UnityEngine;

public class TimedNoteSpawner : MonoBehaviour
{
    public GameObject notePrefab;  // Assign in Inspector
    public Transform spawnPoint;   // Assign in Inspector
    public float noteSpeed = 5f;   // Speed of falling notes
    private float spawnTime = 2.5f; // Time to spawn the note

    private bool noteSpawned = false; // Ensure note only spawns once

    void Update()
    {
        if (!noteSpawned && Time.time >= spawnTime)
        {
            SpawnNote();
            noteSpawned = true;
        }
    }

    void SpawnNote()
    {
        GameObject note = Instantiate(notePrefab, spawnPoint.position, Quaternion.identity);
        note.GetComponent<Rigidbody2D>().velocity = Vector2.down * noteSpeed; // Moves downward
    }
}
