using UnityEngine;

public class NoteManager : MonoBehaviour
{
    public NoteSpawner noteSpawner;
    public float[] noteTimings; // Seconds where notes should spawn
    private int noteIndex = 0;
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
                noteSpawner.SpawnNote();
                noteIndex++;
            }
        }
    }
}
