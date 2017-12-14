using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollow : MonoBehaviour
{
    public GameObject player;

    Vector3 cameraPosition;

    public float followSpeed = 3f;

    public float offsetX = 0f;
    public float offsetY = 25f;
    public float offsetZ = -35f;

    void LateUpdate()
    {
        cameraPosition.x = player.transform.position.x + offsetX;
        cameraPosition.y = player.transform.position.y + offsetY;
        cameraPosition.z = player.transform.position.z + offsetZ;

        transform.position = Vector3.Lerp(transform.position, cameraPosition, followSpeed * Time.deltaTime);

        transform.LookAt(player.transform.position);
    }
}
