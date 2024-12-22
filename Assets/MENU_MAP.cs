using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MENU_MAP : MonoBehaviour
{
    // Start is called before the first frame update
 public void MAP1()
 {
    SceneManager.LoadScene("Map_v1");
 }
  public void MAP2()
 {
    SceneManager.LoadScene("Map_v2");
 }
 public void quaylaimenumap()
 {
    SceneManager.LoadScene("MENU_CHINH");

 }
}
