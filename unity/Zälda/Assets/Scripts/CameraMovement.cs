﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float smoothing;
    [SerializeField] Vector2 maxPosition;
    [SerializeField] Vector2 minPosition;


    private void LateUpdate()
    {
        if (transform.position != target.position)
        {
            Vector3 targetPosition = new Vector3(
                target.position.x,
                target.position.y,
                transform.position.z
            );

            targetPosition.x = Mathf.Clamp(
                targetPosition.x,
                minPosition.x,
                maxPosition.x
            );

            targetPosition.y = Mathf.Clamp(
                targetPosition.y,
                minPosition.y,
                maxPosition.y
            );

            transform.position = Vector3.Lerp(
                transform.position,
                targetPosition,
                smoothing
            );
        }
    }


    public void ChangePosition(Vector2 minChange, Vector2 maxChange)
    {
        minPosition += minChange;
        maxPosition += maxChange;
    }
}
