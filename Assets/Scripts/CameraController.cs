using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;


    private void Update()
    {
        transform.position = new Vector3(player.position.x + 3, player.position.y, transform.position.z);
        print("player.position.x: " + player.position.x + "player.position.y: " + player.position.y);
    }
}
