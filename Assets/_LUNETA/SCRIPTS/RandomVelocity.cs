using UnityEngine;

public class RandomVelocity : MonoBehaviour
{
    public float speed;

    void Reset()
    {
        speed = 10.0f;
    }

    void Start()
    {
        if (gameObject.GetComponent<Rigidbody>())
            GetComponent<Rigidbody>().velocity = Random.onUnitSphere * speed;
    }
}
