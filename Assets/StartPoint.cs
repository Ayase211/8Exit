using UnityEngine;

public class PlayerLoopWarp : MonoBehaviour
{
    public Transform startPoint;   // ← 追加
    public Transform rightPoint;   // 右端（必要なら）

    void OnTriggerEnter2D(Collider2D col)
    {
        // LeftPoint に触れたら元の位置へワープ
        if (col.CompareTag("LeftPoint"))
        {
            transform.position = startPoint.position;
        }

        // 右端に触れたら左へ戻す場合（必要なら）
        if (col.CompareTag("RightPoint"))
        {
            transform.position = startPoint.position;
        }
    }
}