using UnityEngine;

public class LoopManager : MonoBehaviour
{
    public SignNumberController signNumber;
    public Transform player;
    public Transform corridorRoot;
    public Vector2 corridorStartPos;

    public int loopCount = 0;
    public int exitCount = 0;

    public bool currentStrange;

    private void Start()
    {
        currentStrange =
            FindObjectOfType<StrangeEventManager>()
            .TrySpawnEvent(loopCount);

        signNumber.SetNumber(exitCount);
    }

    public void CorrectAnswer()
    {
        exitCount++;

        Debug.Log("正解！");
        Debug.Log("出口カウント : " + exitCount);

        signNumber.SetNumber(exitCount);

        DoLoop();
    }

    public void WrongAnswer()
    {
        exitCount = 0;

        Debug.Log("不正解");

        signNumber.SetNumber(exitCount);

        DoLoop();
    }

    public void DoLoop()
    {
        loopCount++;

        player.position = new Vector2(0f, -1.44f);
        corridorRoot.position = corridorStartPos;

        currentStrange =
            FindObjectOfType<StrangeEventManager>()
            .TrySpawnEvent(loopCount);

        Debug.Log("Loop : " + loopCount);
    }
}