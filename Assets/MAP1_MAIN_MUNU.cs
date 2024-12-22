using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MAP1_MAIN_MUNU : MonoBehaviour
{
        void Update()
    {
        // Nhấn ESC để thoát chế độ khóa chuột
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None; // Mở khóa chuột
            Cursor.visible = true;                 // Hiển thị con trỏ
        }
    }
   public void Menu_map()
 {
    SceneManager.LoadScene("MENUMAP");
    Debug.Log("BackToMenu function called!");
 }
  
}
