using UnityEngine;

public class BackTrigger : MonoBehaviour
{
    public Transform teleportPoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            LoopManager loop = FindObjectOfType<LoopManager>();

            if (loop.currentStrange)
            {
                loop.CorrectAnswer();
            }
            else
            {
                loop.WrongAnswer();
            }

            collision.transform.position = teleportPoint.position;
        }
    }
}