using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MENU_WINNER : MonoBehaviour
{
    public void choilai()
    {
       Time.timeScale = 1f;  
        SceneManager.LoadScene("Map_v1");
    }
    public void mainmenu()
    {
        SceneManager.LoadScene("MENU_CHINH");
    }
}
