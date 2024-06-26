using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public Transform[] backgrounds;

    private void Update()
    {
        for (int i=0; i<backgrounds.Length; i++)
        {
            backgrounds[i].Translate(Vector3.left * Time.deltaTime);
            if (backgrounds[0].position.x <= -8f)
            {
                backgrounds[0].position = backgrounds[1].position + new Vector3(8, 0, 0);
                Transform temp = backgrounds[0];
                backgrounds[0] = backgrounds[1];
                backgrounds[1] = temp;
            }
        }
    }
}
