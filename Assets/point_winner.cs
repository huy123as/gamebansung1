using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point_winner : MonoBehaviour
{
    public GameObject WINNER;
    public GameObject txtmenu;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Kiểm tra nếu đối tượng là "Player"
        {
            

            ShowVictoryMenu();
        }
        else
        {
            WINNER.SetActive(false);
        }
    }

    void ShowVictoryMenu()
    {
        // Hiện menu chiến thắng
        if (WINNER != null)
        {
            WINNER.SetActive(true);
            txtmenu.SetActive(false);
            Time.timeScale = 0f; // Dừng thời gian
            Cursor.lockState = CursorLockMode.None; // Hiện con trỏ chuột
            Cursor.visible = true;
        }
        else
        {
            Debug.LogError("WINNER GameObject chưa được gán trong Inspector!");
        }
    }
}
