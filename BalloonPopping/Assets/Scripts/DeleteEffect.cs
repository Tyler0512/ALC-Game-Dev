using UnityEngine;

public class EffectDeleter : MonoBehaviour
{

    public int timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, timer);
    }
}
