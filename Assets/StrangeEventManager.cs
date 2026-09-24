using UnityEngine;

public class StrangeEventManager : MonoBehaviour
{
    public SpriteRenderer[] signs; // 7‚Â‚ÌŠÅ”Â

    // š ˆÙ•Ï‚ª‹N‚«‚½‚ç true ‚ğ•Ô‚·
    public bool TrySpawnEvent(int loop)
    {
        // ‘SŠÅ”Â‚ğŒ³‚É–ß‚·
        foreach (var s in signs)
        {
            s.flipY = false;
        }

        // 30%‚ÌŠm—¦‚ÅˆÙ•Ï”­¶
        if (Random.value < 0.3f)
        {
            int index = Random.Range(0, signs.Length);
            signs[index].flipY = true;

            Debug.Log("ˆÙ•Ï”­¶: ŠÅ”Â " + index + " ‚ª‹t‚³‚Ü‚É‚È‚Á‚½");
            return true; // š ˆÙ•Ï‚ ‚è
        }

        Debug.Log("ˆÙ•Ï‚È‚µ");
        return false; // š ˆÙ•Ï‚È‚µ
    }
}
