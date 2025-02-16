using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    public GameObject notePrefab; // Assign the Note Prefab in Inspector
    public Transform spawnPoint; // Assign where notes should appear
    public float noteSpeed = 5f; // Adjust speed for timing

    public void SpawnNote()
    {
        GameObject note = Instantiate(notePrefab, spawnPoint.position, Quaternion.identity);
        note.GetComponent<Rigidbody2D>().velocity = Vector2.down * noteSpeed; // Moves down
    }
}
