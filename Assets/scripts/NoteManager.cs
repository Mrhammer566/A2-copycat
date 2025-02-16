using UnityEngine;

public class NoteManager : MonoBehaviour
{
    public GameObject notePrefab;
    public Transform spawnPoint; // Where notes spawn from
    public float[] noteTimings = {2.5f}; // Array of spawn times for notes
    public float noteSpeed = 5f; // Speed at which notes fall
    private int noteIndex = 1; // Keeps track of the current note being spawned
    private float songStartTime;

    void Start()
    {
        songStartTime = Time.time;
    }

    void Update()
    {
        if (noteIndex < noteTimings.Length)
        {
            if (Time.time - songStartTime >= noteTimings[noteIndex])
            {
                SpawnNote();
                noteIndex++;
            }
        }
    }

    void SpawnNote()
    {
        GameObject note = Instantiate(notePrefab, spawnPoint.position, Quaternion.identity);
        note.GetComponent<Rigidbody2D>().velocity = Vector2.down * noteSpeed; // Makes it fall
    }
}
