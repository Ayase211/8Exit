using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float w = GetComponent<SpriteRenderer>().bounds.size.x;
        Debug.Log("îwåiÇÃïù = " + w);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
