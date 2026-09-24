using UnityEngine;

public class BGLooper : MonoBehaviour
{
    public float scrollSpeed = 2f;

    private float width;
    private Transform bgA;
    private Transform bgB;

    void Start()
    {
        // 子が1つなら複製して2枚にする
        if (transform.childCount == 1)
        {
            Transform original = transform.GetChild(0);
            Transform clone = Instantiate(original, transform);
            clone.name = original.name + "_Clone";
        }

        // 2枚取得
        bgA = transform.GetChild(0);
        bgB = transform.GetChild(1);

        // 幅を取得（ローカルスケールを考慮）
        SpriteRenderer sr = bgA.GetComponent<SpriteRenderer>();
        width = sr.sprite.bounds.size.x * bgA.localScale.x;

        // 初期位置を並べる
        bgB.localPosition = new Vector3(width, 0, 0);
    }

    void Update()
    {
        // 左に移動
        bgA.Translate(Vector3.left * scrollSpeed * Time.deltaTime);
        bgB.Translate(Vector3.left * scrollSpeed * Time.deltaTime);

        // Aが左に抜けたら右へ移動
        if (bgA.localPosition.x <= -width)
        {
            bgA.localPosition = new Vector3(bgB.localPosition.x + width, 0, 0);
            Swap();
        }

        // Bが左に抜けたら右へ移動
        if (bgB.localPosition.x <= -width)
        {
            bgB.localPosition = new Vector3(bgA.localPosition.x + width, 0, 0);
            Swap();
        }
    }

    void Swap()
    {
        Transform temp = bgA;
        bgA = bgB;
        bgB = temp;
    }
}