using UnityEngine;

public class NoteTrigger : MonoBehaviour
{
    private bool noteInZone = false;
    private GameObject currentNote;

    void Update()
    {
        // Detect spacebar input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (noteInZone && currentNote != null)
            {
                Destroy(currentNote); // Remove the note when hit
                Debug.Log("Hit!");
                noteInZone = false;
                currentNote = null;
            }
            else
            {
                Debug.Log("Miss!");
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if a note enters the trigger zone
        if (other.CompareTag("Note"))
        {
            noteInZone = true;
            currentNote = other.gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        // Check if the note leaves the trigger zone
        if (other.CompareTag("Note"))
        {
            noteInZone = false;
            currentNote = null;
        }
    }
}
