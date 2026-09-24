using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    private SpriteRenderer sr;
    public float speed = 5f;
    public Sprite[] walkSprites;
    float time = 0;
    int idx = 0;
    SpriteRenderer spriteRenderer;

    private void Start()
    {
        Application.targetFrameRate = 60;
        this.spriteRenderer = GetComponent<SpriteRenderer>();
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        bool isMoving = false;

        float x = 0;

        // 入力を統一
        if (Keyboard.current.aKey.isPressed)
        {
            x = -1;
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            x = 1;
        }

        // 移動
        if (x != 0)
        {
            transform.Translate(new Vector3(x * speed * Time.deltaTime, 0, 0));
            isMoving = true;
        }

        // アニメーション
        if (isMoving)
        {
            this.time += Time.deltaTime;
            if (this.time > 0.12f)
            {
                this.time = 0;
                this.spriteRenderer.sprite = this.walkSprites[this.idx];
                this.idx = (this.idx + 1) % this.walkSprites.Length;
            }
        }
        else
        {
            this.idx = 0;
            this.spriteRenderer.sprite = this.walkSprites[0];
        }

        // 向き変更（x を使う）
        if (x > 0)
        {
            sr.flipX = false;  // 右向き
        }
        else if (x < 0)
        {
            sr.flipX = true;   // 左向き
        }
    }
}