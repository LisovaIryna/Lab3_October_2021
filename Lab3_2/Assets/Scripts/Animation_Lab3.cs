using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animation_Lab3 : MonoBehaviour
{
    void OnMouseDown()
    {
        GetComponent<Image>().color = new Color(255, 255, 255);
        transform.localScale = new Vector3(0.55f, 0.55f, 0.55f);
    }

    void OnMouseUp()
    {
        GetComponent<Image>().color = new Color(255, 215, 0);
        transform.localScale = new Vector3(1,1,1);
    }
}