using UnityEngine;

public class LoopTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            LoopManager loop = FindObjectOfType<LoopManager>();

            if (!loop.currentStrange)
            {
                loop.CorrectAnswer();
            }
            else
            {
                loop.WrongAnswer();
            }
        }
    }
}