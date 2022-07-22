using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public ItemBox[] itemBoxes;
    public bool isGameOver;
    public GameObject winUI;
    void Start()
    {
        isGameOver = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(0);
        }
        if (isGameOver == true)
            return;
        int cnt = 0;
        for (int i = 0; i < 3; i++)
        {
            if (itemBoxes[i].isOverrapped == true)
            {
                cnt++;
            }
        }

        if (cnt >= 3)
        {
            isGameOver = true;
            winUI.SetActive(true);
            Debug.Log("게임 승리");
        }
    }
}
