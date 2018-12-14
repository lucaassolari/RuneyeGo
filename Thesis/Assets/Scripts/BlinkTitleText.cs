﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BlinkTitleText : MonoBehaviour
{

    Text flashingText;

    void Start()
    {
        flashingText = GetComponent<Text>();
        StartCoroutine(BlinkText());
    }

    public IEnumerator BlinkText()
    {
        while (true)
        {
            flashingText.text = "Tocca lo schermo per iniziare";
            yield return new WaitForSeconds(.5f);
            flashingText.text = "";
            yield return new WaitForSeconds(.5f);

        }
    }

}