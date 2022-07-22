using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager gameManager;
    public float speed = 10f; // 속도지정
    private Rigidbody playerRigidbody; // 리지드바디를 통해 속도와 힘을 가한다.
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (!gameManager.isGameOver)
        {
            // 오른쪽키 왼쪽키 입력시 -1 ~ +1을 리턴
            float inputX = Input.GetAxis("Horizontal");
            float inputZ = Input.GetAxis("Vertical");
            float fallSpeed = playerRigidbody.velocity.y;
            Vector3 velocity = new Vector3(inputX, 0, inputZ);
        
            velocity *= speed; // (inputX * speed, 0, inputZ * speed)
            velocity.y = fallSpeed; // (inputX * speed, fallSpeed, inputZ * speed)

            playerRigidbody.velocity = velocity;
        }
    }
}
