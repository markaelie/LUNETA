using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0, 0, 0);
    public float speed;

    void Start()
    {
        transform.position = player.transform.position + offset;
        transform.LookAt(player.transform.position);
    }

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, player.transform.position + offset, speed);
    }
}
