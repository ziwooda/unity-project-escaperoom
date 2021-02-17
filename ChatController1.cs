using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatController1 : MonoBehaviour
{
    public Text ChatText;
    void Start()
    {
        StartCoroutine(TextPractice());
    }
    IEnumerator NormalChat(string fullText) {
        int a = 0;
        string writerText = "";
        for (a = 0; a < fullText.Length; a++) {
            writerText += fullText[a];
            ChatText.text = writerText;
            yield return new WaitForSeconds(0.1f);
        }
    }
    IEnumerator TextPractice() {
        yield return StartCoroutine(NormalChat("역사를 잊은 자에게 미래가 없다.\n"+"나라의 아팠던 과거를 잊지 말도록!\n"+"수고하셨습니다."));
        Application.Quit();
    }
}