using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Mainmenu : MonoBehaviour
{
    // Start is called before the first frame update
 public void playgame()
 {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);
 }
  public void setting()
 {
     SceneManager.LoadScene("MENU_OPtion");
 }
  public void Exit()
 {
    Application.Quit();
 }
}
