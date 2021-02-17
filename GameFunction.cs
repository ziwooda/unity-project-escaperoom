using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameFunction : MonoBehaviour {
    public Text clickText;
    public int MouseClick = 20;

    void Start() {
        clickText.text = "기회:20";
    }

    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            MouseClick--;
            clickText.text = "기회: " + MouseClick.ToString();
        }

        if (MouseClick == 0) {
            clickText.text = "기회 끝!";
            SceneManager.LoadScene("failed");
        }
    }
}
