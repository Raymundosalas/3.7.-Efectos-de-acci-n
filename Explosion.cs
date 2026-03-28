using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float duration = 1f;

    void Start()
    {
        Destroy(gameObject, duration);
    }
}
