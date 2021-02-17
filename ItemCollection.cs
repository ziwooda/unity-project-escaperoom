using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollection : MonoBehaviour
{
    public int item = 0;
    public Text itemText;
    void Update()
    {
        GetItem();
    }
    void GetItem()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray touchray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(touchray, out hit))
            {
                item++;
                itemText.text = hit.collider.gameObject.name + " 발견! (" + item.ToString() + ")";
                Destroy(hit.collider.gameObject);
            }
            if (item == 8)
            {
                SceneManager.LoadScene("success");
            }
        }
    }
}