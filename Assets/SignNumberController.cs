using UnityEngine;

public class SignNumberController : MonoBehaviour
{
    public SpriteRenderer signRenderer;   // 看板のSpriteRenderer
    public Sprite[] numberSprites;        // 0〜8 + EXIT の画像を入れる

    public void SetNumber(int num)
    {
        // 範囲チェック
        if (num >= 0 && num < numberSprites.Length)
        {
            signRenderer.sprite = numberSprites[num];
        }
    }
}