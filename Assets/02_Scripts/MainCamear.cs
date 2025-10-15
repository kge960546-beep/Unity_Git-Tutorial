using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamear : MonoBehaviour
{
    [Header("Target")]
    [SerializeField] Transform player;

    [Header("CamearMoveMargin")]
    [SerializeField] float smoothing = 0.1f;
    [SerializeField] Vector2 minCamearBoundary;
    [SerializeField] Vector2 maxCamearBoundary;    

    void FixedUpdate()
    {
        Vector3 targetPos = new Vector3(player.position.x, player.position.y, this.transform.position.z);
        targetPos.x = Mathf.Clamp(targetPos.x, minCamearBoundary.x, maxCamearBoundary.x);
        transform.position = Vector3.Lerp(transform.position, targetPos, smoothing);
    }
}
