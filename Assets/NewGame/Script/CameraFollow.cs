using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector3 playerPosition;
    private Vector3 cameraPosition;
    public float maxHeight = 2f, minHeight = -0.5f;

    public float speed;
    private float movespeed;

    public float minPositionX;
    public float terPositionX;


    private void Start()
    {
        playerPosition = GameObject.Find("Player").transform.position;
        cameraPosition = transform.position;
    }

    private void Update()
    {
        playerPosition = GameObject.Find("Player").transform.position;
        if (playerPosition.y > -6.18f) {
            cameraPosition = transform.position;
            //カメラはプレイヤーの視点に従う
            var clampedY = Mathf.Clamp(playerPosition.y, minHeight, maxHeight);//カメラの高さを制限する
            transform.position = new Vector3(playerPosition.x >= 83.20f ? 83.20f : playerPosition.x, clampedY, cameraPosition.z);
            movespeed = speed * Time.deltaTime;
            transform.Translate(Vector3.left * movespeed, Space.World);
            if (transform.localPosition.x < minPositionX)
            {
                transform.localPosition = new Vector3(terPositionX, transform.localPosition.y, transform.localPosition.z);
            }
        }
    }
}