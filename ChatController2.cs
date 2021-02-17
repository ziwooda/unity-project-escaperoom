using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatController2 : MonoBehaviour
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
        yield return StartCoroutine(NormalChat("아쉽게 임무 성공에 실패했구만.\n"+"우리의 역사를 알기 위해 다시 한번 도전해보는 것은 어떻겠소.\n"));
    }
}