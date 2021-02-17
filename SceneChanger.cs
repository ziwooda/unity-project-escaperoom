using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
    public void SceneChange1() {
        SceneManager.LoadScene("PlayRule");
    }
    public void SceneChange2() {
        SceneManager.LoadScene("RoomEscape");
    }
    public void SceneChange3() {
        SceneManager.LoadScene("success");
    }
    public void SceneChange4() {
        SceneManager.LoadScene("failed");
    }
}
